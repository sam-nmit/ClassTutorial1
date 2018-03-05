using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string name;
        private string speciality;
        private string phone;
        
        private decimal _totalValue;

        private clsWorksList _worksList;
        private clsArtistList _artistList;
        
        private static frmArtist artistDialog = new frmArtist();
        private byte sortOrder;

        public clsArtist(clsArtistList prArtistList)
        {
            _worksList = new clsWorksList();
            _artistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(name, speciality, phone, sortOrder, _worksList, _artistList);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                artistDialog.GetDetails(ref name, ref speciality, ref phone, ref sortOrder);
                _totalValue = _worksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return name;
        }

        public decimal GetWorksValue()
        {
            return _totalValue;
        }
    }
}
