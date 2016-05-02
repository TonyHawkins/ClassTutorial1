using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _width;
        private float _height;
        private string _type;

        [NonSerialized()]
        private static frmPhotograph _PhotoDialog;

        public float Width
        {
            get
            {
                return Width1;
            }

            set
            {
                Width1 = value;
            }
        }

        public float Width1
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public override void EditDetails()
        { 
            if (_PhotoDialog == null)
            _PhotoDialog = new frmPhotograph();
            _PhotoDialog.SetDetails(this);
        }
    }
}
