using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MONITORING
{
    class FolderListViewModel : InsetViewModel
    {
        
        public FolderListViewModel(Component folder, Database database) 
           : base(folder, database)
        {

        }

        protected override void LoadSettings()
        {
            foreach (Setting setting in component.Settings)
            {
                switch (setting.CFG_ID)
                { 
                    case 1:
                        Activate = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;

                    case 2:
                        int number = Convert.ToInt32(setting.Val);
                        switch (number)
                        {
                            case 1:
                                ByTurns = true;
                                break;
                            case 2:
                                Mosaic = true;
                                break;
                            case 3:
                                Cascade = true;
                                break;
                        }
                        break;

                    case 3:
                        AutoRotate = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                    case 4:
                        Height = Convert.ToInt32(setting.Val);
                        break;
                    case 5:
                        Width = Convert.ToInt32(setting.Val);
                        break;
                    case 6:
                        PositionX = Convert.ToInt32(setting.Val);
                        break;
                    case 7:
                        PositionY = Convert.ToInt32(setting.Val);
                        break;
                    case 8:
                        SavePosition = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                    case 9:
                        ForcedToDisplay = Convert.ToBoolean(Convert.ToInt32(setting.Val));
                        break;
                }
            }

            
        }

        protected override void UpdateComponent()
        {
            foreach (Setting setting in component.Settings)
            {
                switch (setting.CFG_ID)
                {
                    case 1:
                        setting.Val = Convert.ToInt32(Activate).ToString();
                        break;

                    case 2:
                        int number = 0;
                        if (ByTurns)
                            number = 1;
                        else if (Mosaic)
                            number = 2;
                        else if (Cascade)
                            number = 3;
                        setting.Val = number.ToString();
                        break;

                    case 3:
                        setting.Val = Convert.ToInt32(AutoRotate).ToString();
                        break;

                    case 4:
                        setting.Val = Height.ToString();
                        break;

                    case 5:
                        setting.Val = Width.ToString();
                        break;

                    case 6:
                        setting.Val = Convert.ToInt32(SavePosition).ToString();
                        break;
                    case 7:
                        setting.Val = Convert.ToInt32(ForcedToDisplay).ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private bool activate;
        public bool Activate
        {
            get { return activate; }
            set
            {
                activate = value;
                OnPropertyChanged("Activate");
            }
        }

        private bool byTurns;
        public bool ByTurns
        {
            get { return byTurns; }
            set
            {
                byTurns = value;    
                OnPropertyChanged("ByTurns");
                if (ByTurns)
                {
                    AutoRotate = true;
                    AutoRotateEnabled = false;
                }
            }
        }

        private bool mosaic;
        public bool Mosaic
        {
            get { return mosaic; }
            set
            {
                mosaic = value;
                OnPropertyChanged("Mosaic");
                if (Mosaic)
                    AutoRotateEnabled = true;
            }
        }

        private bool cascade;
        public bool Cascade
        {
            get { return cascade; }
            set
            {
                cascade = value;
                OnPropertyChanged("Cascade");
                if (Cascade)
                    AutoRotateEnabled = true;
            }
        }
                    
        private bool autoRotate;
        public bool AutoRotate
        {
            get { return autoRotate; }
            set
            {
                autoRotate = value;
                OnPropertyChanged("AutoRotate");
            }
        }

        private bool autoRotateEnabled;
        public bool AutoRotateEnabled
        {
            get { return autoRotateEnabled; }
            set
            {
                autoRotateEnabled = value;
                OnPropertyChanged("AutoRotateEnabled");
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }

        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged("Width");
            }
        }

        private int positionX;
        public int PositionX
        {
            get { return positionX; }
            set
            {
                positionX = value;
                OnPropertyChanged("PositionX");
            }
        }

        private int positionY;
        public int PositionY
        {
            get { return positionY; }
            set
            {
                positionY = value;
                OnPropertyChanged("PositionY");
            }
        }

        private bool savePosition;
        public bool SavePosition
        {
            get { return savePosition; }
            set
            {
                savePosition = value;
                OnPropertyChanged("SavePosition");
            }
        }

        private bool forcedToDisplay;
        public bool ForcedToDisplay
        {
            get { return forcedToDisplay; }
            set
            {
                forcedToDisplay = value;
                OnPropertyChanged("ForcedToDisplay");
            }
        }

    }
}
