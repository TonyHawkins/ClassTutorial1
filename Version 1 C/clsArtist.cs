using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _name;
        private string _speciality;
        private string _phone;
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        private static frmArtist artistDialog = new frmArtist();

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Speciality
        {
            get
            {
                return _speciality;
            }

            set
            {
                _speciality = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public decimal TotalValue
        {
            get
            {
                return _TotalValue;
            }
        }

        public clsWorksList WorksList
        {
            get
            {
                return _WorksList;
            }
        }

        public clsArtistList ArtistList
        {
            get
            {
                return _ArtistList;
            }
        }

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(Name, Speciality, Phone, WorksList, ArtistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref _name, ref _speciality, ref _phone);
                _TotalValue = WorksList.GetTotalValue();
            }
        }

  //      public string GetKey()
  //      {
  //          return Name;
  //      }

   //     public decimal GetWorksValue()
    //    {
    //        return TotalValue;
     //   }
    }
}
