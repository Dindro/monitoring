using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace MONITORING
{
    class RulesItemViewModel : PropertyChangedClass
    {
        public RulesItemViewModel()
        {
            CheckTypes = new List<RulesCellModel>()
            {
                new RulesCellModel() { ID = 1, Value="More Than"},
                new RulesCellModel() { ID = 2, Value = "Less Than" },
                new RulesCellModel() { ID = 3, Value = "Equal" },
                new RulesCellModel() { ID = 4, Value = "Not Equal" }
            };

            ColorTypes = new List<RulesCellModel>()
            {
                new RulesCellModel() { ID = 1, Value="Red"},
                new RulesCellModel() { ID = 2, Value = "Blue" },
                new RulesCellModel() { ID = 3, Value = "Green" },
                new RulesCellModel() { ID = 4, Value = "Yellow" }
            };

            AlertTypes = new List<RulesCellModel>()
            {
                new RulesCellModel() { ID = 1, Value="Error"},
                new RulesCellModel() { ID = 2, Value = "Warning" },
                new RulesCellModel() { ID = 3, Value = "Info" }
            };

        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int checkType;
        public int CheckType
        {
            get { return checkType; }
            set
            {
                checkType = value;
                OnPropertyChanged("CheckType");
            }
        }

        private List<RulesCellModel> checkTypes;
        [ScriptIgnore]
        public List<RulesCellModel> CheckTypes
        {
            get { return checkTypes; }
            set { checkTypes = value; }
        }

        private string value;
        public string Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        bool color;
        public bool Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }

        private string colorType;
        public string ColorType
        {
            get { return colorType; }
            set
            {
                colorType = value;
                OnPropertyChanged("ColorType");
            }
        }

        private List<RulesCellModel> colorTypes;
        [ScriptIgnore]
        public List<RulesCellModel> ColorTypes
        {
            get { return colorTypes; }
            set { colorTypes = value; }
        }

        private bool sound;
        public bool Sound
        {
            get { return sound; }
            set
            {
                sound = value;
                OnPropertyChanged("Sound");
            }
        }

        private int soundType;
        public int SoundType
        {
            get { return soundType; }
            set
            {
                soundType = value;
                OnPropertyChanged("SoundType");
            }
        }

        private List<RulesCellModel> soundTypes;
        [ScriptIgnore]
        public List<RulesCellModel> SoundTypes
        {
            get { return soundTypes; }
            set { soundTypes = value; }
        }

        private int alertType;
        public int AlertType
        {
            get { return alertType; }
            set
            {
                alertType = value;
                OnPropertyChanged("AlertType");
            }
        }

        private List<RulesCellModel> alertTypes;
        [ScriptIgnore]
        public List<RulesCellModel> AlertTypes
        {
            get { return alertTypes; }
            set { alertTypes = value; }
        }
    }
}
