using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _width;
        private float theHeight;
        private string theType;

        [NonSerialized()]
        private static frmPhotograph photoDialog;

        public float Width
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

        public override void EditDetails()
        {
            if (photoDialog == null)
            {
                photoDialog = new frmPhotograph();
            }
            photoDialog.SetDetails(_Name, theDate, theValue, _width, theHeight, theType);
            if (photoDialog.ShowDialog() == DialogResult.OK)
            {
                photoDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref _width, ref theHeight, ref theType);
            }
        }
    }
}
