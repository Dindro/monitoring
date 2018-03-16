using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace MONITORING
{
    class Database 
    {
        readonly SQLiteConnection connection;

        public Database(string nameDB)
        {
            connection = new SQLiteConnection(string.Format("Data Source={0};", nameDB));
            IsExistsDB(nameDB); //Проверка на существование БД
        }

        //Проверка на существование Базы Данных
        void IsExistsDB(string nameDB)
        {
            if (File.Exists(nameDB) == false) //Если не существует база данных
            {
                SQLiteConnection.CreateFile(nameDB); //Создаем базу данных(файл)
                string commandText = "CREATE TABLE CASE_TAB( " +
                        "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, title TEXT,action NUM,code TEXT,addl_data TEXT,parent NUM," +
                        "child NUM, cdate DATETIME DEFAULT CURRENT_TIMESTAMP," +
                        "mdate DATETIME DEFAULT CURRENT_TIMESTAMP," +
                        " UNIQUE(id) ON CONFLICT ABORT,UNIQUE(parent, child) ON CONFLICT ABORT);";
                CreateDB(commandText); //Создаем таблицу

                commandText = "CREATE TABLE CFG_TAB(" +
                    "id NUM REFERENCES CASE_TAB(ID) ON DELETE CASCADE," +
                    "cfg_id INT,type INT,val TEXT,UNIQUE(id, cfg_id) ON CONFLICT ABORT );";
                CreateDB(commandText); //Создаем таблицу

                commandText = "CREATE TABLE TEMPLATE_TAB(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    " code TEXT);";
                CreateDB(commandText);
            }
        }

        //Создание БД
        void CreateDB(string commandText)
        {
            using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
            {
                connection.Open();
                command.ExecuteNonQuery(); //создаем таблицу
                connection.Close();
            }
        }

        public List<Folder> GetFolders(Action action)
        {
            List<Folder> folders = new List<Folder>();
            using (SQLiteCommand command = new SQLiteCommand("SELECT id, title, code, addl_data, parent, child FROM CASE_TAB WHERE action = "
                + Convert.ToInt32(action) + " AND child = 0 ORDER BY parent asc, child asc;", connection))
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader(); //выбираем строки по возрастанию
                
                foreach (DbDataRecord record in reader)
                {
                    int id = Convert.ToInt32(record["id"]);
                    string title = record["title"].ToString();

                    string code = record["code"].ToString();
                    string addl_data = record["addl_data"].ToString();
                    int parent = Convert.ToInt32(record["parent"]);
                    int child = Convert.ToInt32(record["child"]);

                    List<Setting> settings = GetSettings(id);
                    folders.Add(new Folder(id, title, action, code, addl_data, parent, child, settings));
                }
                reader.Close();
                connection.Close();
            }
            return folders;
        }

        public List<Select> GetSelects(Folder folder)
        {
            List<Select> selects = new List<Select>();
            
            using (SQLiteCommand command = new SQLiteCommand("SELECT id, title, code, addl_data, parent, child FROM CASE_TAB WHERE action = "
                + Convert.ToInt32(folder.Action) + " AND parent = " + folder.Parent + " AND child !=0  ORDER BY parent asc, child asc;", connection))
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader(); //выбираем строки по возрастанию
                
                foreach (DbDataRecord record in reader)
                {
                    int id = Convert.ToInt32(record["id"]);
                    string title = record["title"].ToString();

                    string code = record["code"].ToString();
                    string addl_data = record["addl_data"].ToString();
                    int parent = Convert.ToInt32(record["parent"]);
                    int child = Convert.ToInt32(record["child"]);

                    List<Setting> settings = GetSettings(id);
                    selects.Add(new Select(id, title, folder.Action, code, addl_data, parent, child, settings));
                }
                reader.Close();
                connection.Close();
            }
            return selects;
        }

        public List<Setting> GetSettings(int ID)
        {
            List<Setting> settings = new List<Setting>();
            using (SQLiteCommand command = new SQLiteCommand("SELECT CFG_ID, TYPE, VAL FROM CFG_TAB WHERE ID ="
                + ID + ";", connection))
            {
                SQLiteDataReader reader = command.ExecuteReader(); //выбираем строки по возрастанию
                foreach (DbDataRecord record in reader)
                {
                    int cfg_id = Convert.ToInt32(record["CFG_ID"]); //Узнаем id контрола
                    string type = record["TYPE"].ToString();
                    string val = record["VAL"].ToString();

                    settings.Add(new Setting(cfg_id, type, val));
                }
                reader.Close();
            }
            return settings;
        }

        public void DeleteFolder(Folder folder)
        {
            DeleteComponent(folder);
            foreach (Select select in folder.Selects)
            {
                DeleteComponent(select);
            }
        }

        public void DeleteComponent(Component component)
        {
            using (SQLiteCommand commands = new SQLiteCommand("DELETE FROM CASE_TAB WHERE ID = " + component.ID + ";", connection))
            {
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
            DeleteSettings(component.ID);
        }

        private void DeleteSettings(int ID)
        {
            using (SQLiteCommand commands = new SQLiteCommand("DELETE FROM CFG_TAB WHERE ID = " + ID + ";", connection))
            {
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateComponent(Component component)
        {
            using (SQLiteCommand commands = new SQLiteCommand("UPDATE CASE_TAB SET [code]=@code, [addl_data]=@addl_data WHERE ID = " + component.ID
                    + ";", connection))
            {
                commands.Parameters.AddWithValue("code", component.Code);
                commands.Parameters.AddWithValue("addl_data", component.Addl_data);
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
            UpdateSettings(component.ID, component.Settings);
        }

        private void UpdateSettings(int ID, List<Setting> settings)
        {
            connection.Open();
            foreach (Setting setting in settings)
            {
                using (SQLiteCommand commands = new SQLiteCommand("UPDATE CFG_TAB SET [type]=@type, [val]=@val WHERE ID = " + ID 
                    + " AND CFG_ID = "+setting.CFG_ID+";", connection))
                {
                    commands.Parameters.AddWithValue("type", setting.Type);
                    commands.Parameters.AddWithValue("val", setting.Val);
                    commands.ExecuteNonQuery();
                    
                }
            }
            connection.Close();

        }

        public void UpdateTitle(Component component)
        {
            using (SQLiteCommand commands = new SQLiteCommand("UPDATE CASE_TAB SET [title]=@title WHERE ID = " + component.ID + ";", connection))
            {
                commands.Parameters.AddWithValue("title", component.Title);
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
        }


        //Создание папки
        public void SetFolder(Folder folder)
        {
            folder.Parent = GetMaxParent() + 1; //Получаем макс количество папок и прибавляем на 1
            SetComponent(folder);
            SetSettings(folder.ID, folder.Settings);
        }

        //Создание выборки
        public void SetSelect(int parentID, Select select)
        {
            select.Parent = GetParent(parentID);
            select.Child = GetMaxChild(select.Parent)+1;
            SetComponent(select);
            SetSettings(select.ID, select.Settings);
        }

        //Вставка копированной папки
        public void SetСopiedFolder(Folder folder)
        {
            SetFolder(folder);
            foreach (Select select in folder.Selects)
                SetSelect(folder.ID, select);
        }

        public void SetSettings(int ID, List<Setting> settings)
        {
            connection.Open();
            foreach (Setting setting in settings)
            {
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO 'CFG_TAB' ('ID', 'CFG_ID', 'TYPE', 'VAL') " +
                 "VALUES (@ID, @CFG_ID, @TYPE, @VAL);", connection))
                {
                    command.Parameters.AddWithValue("ID", ID);
                    command.Parameters.AddWithValue("CFG_ID", setting.CFG_ID);
                    command.Parameters.AddWithValue("TYPE", setting.Type);
                    command.Parameters.AddWithValue("VAL", setting.Val);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void SetComponent(Component component)
        {
            using (SQLiteCommand command = new SQLiteCommand("INSERT INTO 'CASE_TAB' " +
                "('title', 'action', 'code','addl_data','parent', 'child') " +
                "VALUES (@title, @action,@code,@addl_data, @parent, @child);" +
                "select last_insert_rowid();", connection))
            {
                command.Parameters.AddWithValue("title", component.Title);
                command.Parameters.AddWithValue("action", component.Action);
                command.Parameters.AddWithValue("code", component.Code);
                command.Parameters.AddWithValue("addl_data", component.Addl_data);
                command.Parameters.AddWithValue("parent", component.Parent);
                command.Parameters.AddWithValue("child", component.Child);

                connection.Open();
                component.ID = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }
        }

        //Узнаем parent по ID
        private int GetParent(int parentID)
        {
            int parent = -1;
            using (SQLiteCommand command = new SQLiteCommand("SELECT Parent FROM CASE_TAB WHERE ID ="
                + parentID + ";", connection))
            {
                connection.Open();
                parent = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }
            return parent;
        }

        //Получаем max parent
        int GetMaxParent()
        {
            string commandCount = "SELECT COUNT(*) FROM CASE_TAB WHERE Child = 0;";
            string command = "SELECT MAX([parent]) FROM CASE_TAB WHERE Child = 0;";
            return GetMaxValue(commandCount, command);
        }

        //Получаем max child
        int GetMaxChild(int parent)
        {
            string commandCount = "SELECT COUNT(*) FROM CASE_TAB WHERE parent = " + parent + ";"; //узнаем количество строк
            string command = "SELECT MAX(child) FROM CASE_TAB WHERE parent = " + parent + ";";
            return GetMaxValue(commandCount, command);
        }

        //Получаем максимальное значение
        private int GetMaxValue(string commandCountText, string commandText)
        {
            int maxValue;
            using (SQLiteCommand commandCount = new SQLiteCommand(commandCountText, connection))
            {
                connection.Open();
                int countRow = Convert.ToInt32(commandCount.ExecuteScalar());
                connection.Close();

                if (countRow != 0) //Если количество строк в таблице НЕ 0
                {
                    using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                    {
                        connection.Open();
                        maxValue = Convert.ToInt32(command.ExecuteScalar());
                        connection.Close();
                    }
                }
                else
                    maxValue = 0;
            }
            return maxValue;
        }

        public List<TemplateItem> GetTemplateItems()
        {
            List<TemplateItem> templates = new List<TemplateItem>();
            using (SQLiteCommand command = new SQLiteCommand("SELECT id, code FROM TEMPLATE_TAB;", connection))
            {
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader(); //выбираем строки по возрастанию

                foreach (DbDataRecord record in reader)
                {
                    int id = Convert.ToInt32(record["id"]);
                    string code = record["code"].ToString();

                    templates.Add(new TemplateItem(id, code));
                }
                reader.Close();
                connection.Close();
            }
            return templates;
        }

        public void UpdateTemplateItem(TemplateItem template)
        {
            using (SQLiteCommand commands = new SQLiteCommand("UPDATE Template_TAB SET [code]=@code WHERE ID = " + template.id
                    + ";", connection))
            {
                commands.Parameters.AddWithValue("code", template.code);
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteTemplateItem(TemplateItem template)
        {
            using (SQLiteCommand commands = new SQLiteCommand("DELETE FROM Template_TAB WHERE ID = " + template.id + ";", connection))
            {
                connection.Open();
                commands.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void SetTemplate(string code)
        {
            using (SQLiteCommand command = new SQLiteCommand("INSERT INTO 'TEMPLATE_TAB' ('code') VALUES (@code);", connection))
            {
                command.Parameters.AddWithValue("code", code);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public bool GetAutoRotateParent(int ID)
        {
            bool isChecked;
            using (SQLiteCommand cmd = new SQLiteCommand("Select val FROM CFG_TAB where cfg_id = 3" +
                      " AND id = (select id from case_tab where parent = " +
                      "(select parent from case_tab where id = " + ID + "));", connection))
            {
                connection.Open();
                isChecked = Convert.ToBoolean(Convert.ToInt32(cmd.ExecuteScalar()));
                connection.Close();
            }
            return isChecked;
        }
    }
}
