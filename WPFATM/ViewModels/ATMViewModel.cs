using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFATM.Commands;
using WPFATM.Models;
using WPFATM.Views;

namespace WPFATM.ViewModels
{
    public class ATMViewModel : INotifyPropertyChanged
    {
        ATMDataContext db = null;

        ObservableCollection<Carddetail> detailsList = null ;
        ObservableCollection<TransDetail> transList = null ;

        private Carddetail carddetailsObj = new Carddetail();
        private TransDetail transDetailObj = new TransDetail();

        #region Properties
        public string UI_CardNumber
        {
            get { return carddetailsObj.CardNumber.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    carddetailsObj.CardNumber = long.Parse(value);
                    OnPropertyChanged("UI_CardNo");
                }
            }   
        }

        public string UI_CustomerName
        {
            get { return carddetailsObj.CustomerName; }
            set
            {
                if (value != string.Empty)
                {
                    carddetailsObj.CustomerName = value;
                }
            }
        }

        public string UI_Pin
        {
            get { return carddetailsObj.Pin.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    carddetailsObj.Pin = Convert.ToInt32(value);
                    OnPropertyChanged("UI_Pin");
                }
            }
        }

        public string UI_AccBal
        {
            get { return transDetailObj.AccBal.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transDetailObj.AccBal = Convert.ToDecimal(value);
                    OnPropertyChanged("UI_AccBal");
                }
            }
        }

        public string UI_TransDate
        {
            get { return transDetailObj.TransDate.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transDetailObj.TransDate = Convert.ToDateTime(value);
                    OnPropertyChanged("UI_TransDate");
                }
            }
        }


        #endregion

        #region ICommand
        public ICommand LoginCommand { get; }

        public ICommand ChekBalCommand { get; }

        public ICommand MinistmtCommand { get; }

        public ICommand ShowMinistmtCommand { get; }


        #endregion

        #region Login Command
        public bool CanLogin(object obj)
        {
            if ((this.UI_CardNumber != null) && (this.UI_Pin != null))
            {
                return true;
            }
            return false;
        }

        public void Login(object obj)
        {
            long CardNumber = long.Parse(this.UI_CardNumber);
            int Pin = int.Parse(this.UI_Pin);

            Carddetail carddetail = db.Carddetail.Where(c => c.CardNumber == CardNumber).Select(c => c).Where(c => c.Pin == Pin).SingleOrDefault();
           
            if (carddetail != null)
            {
                ATMTask aTM = new ATMTask();
                aTM.Show();

                MessageBox.Show("welcome User");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }

        }
        #endregion

        #region Check Balance button
        public void ChkAccBal(object obj)
        {
            ShowBalanceForm showbal = new ShowBalanceForm();
            showbal.Show();
        }
        #endregion

        #region Mini Statement Button
        public void Ministmt(object obj)
        {
            MiniStatementForm ministmt = new MiniStatementForm();
            ministmt.Show();
        }
        #endregion

        public void ShowStatement(object obj)
        {
            long CardNumber = long.Parse(this.UI_CardNumber);
            decimal AccBal = decimal.Parse(this.UI_AccBal);
            DateTime TransDate = DateTime.Parse(this.UI_TransDate);

            TransDetail detail = db.TransDetail.Where(c => c.CardNumber == CardNumber).Where(c => c.AccBal == AccBal).Where(c => c.TransDate == TransDate).Select(c => c).FirstOrDefault();

            if(detail != null)
            {
                MessageBox.Show("Your result is" + detail);
            }
            else
            {
                MessageBox.Show("Sorry");
            }
        }
        //select cardnumber, accbal, tranctiondate from transdetails where CardNumber = CardNumber;



        #region Constructor
        public ATMViewModel()
        {
            db = new ATMDataContext();
            LoginCommand = new RelayCommand(Login, CanLogin);
            ChekBalCommand = new RelayCommand(ChkAccBal);
            MinistmtCommand = new RelayCommand(Ministmt);
            ShowMinistmtCommand = new RelayCommand(ShowStatement);

        }
        #endregion

        #region INotifyProperty Member 
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

}
