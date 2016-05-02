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
        
        private static frmArtist _ArtistDialog = new frmArtist();

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
            _ArtistDialog.SetDetails(this);
            _TotalValue = WorksList.GetTotalValue();
            }

        public bool IsDuplicate(string prArtistName)
        {
            return _ArtistList.ContainsKey(prArtistName);
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
