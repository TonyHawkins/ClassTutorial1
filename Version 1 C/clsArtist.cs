using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _name;
        private string _speciality;
        private string _phone;
        
        private decimal _totalvalue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        private static frmArtist artistDialog = new frmArtist();


        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(_name, _speciality, _phone, _WorksList, _ArtistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref _name, ref _speciality, ref _phone);
                _totalvalue = _WorksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return _name;
        }

        public decimal GetWorksValue()
        {
            return _totalvalue;
        }
    }
}
