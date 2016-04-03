using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _weight;
        private string _material;

        [NonSerialized()]
        private static frmSculpture sculptureDialog;

        public override void EditDetails()
        {
            if (sculptureDialog == null)
            {
                sculptureDialog = new frmSculpture();
            }
            sculptureDialog.SetDetails(_name, _date, _value, _weight, _material);
            if (sculptureDialog.ShowDialog() == DialogResult.OK)
            {
                sculptureDialog.GetDetails(ref _name, ref _date, ref _value, ref _weight, ref _material);
            }
        }
    }
}
