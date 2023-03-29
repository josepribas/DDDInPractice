using DddInPractice.UI.Common;
using DDDInPractice.Logic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.UI
{
    public class SnackMachineViewModel: ViewModel
    {
        private readonly SnackMachine _snackMachine;

        public override string Caption => "Snack Machine";
        public string MoneyInTransaction => _snackMachine.MoneyInTransaction.ToString();

        public Command InsertCentCommand { get; private set; }
        public Command InsertTenCentCommand { get; private set; }
        public Command InsertQuarterCommand { get; private set; }
        public Command InsertDollarCommand { get; private set; }
        public Command InsertFiveDollarCommand { get; private set; }
        public Command InsertTwentyDollarCommand { get; private set; }

        public SnackMachineViewModel(SnackMachine snackMachine)
        {
            _snackMachine = snackMachine;

            InsertCentCommand = new Command(() => InsertMoney(Money.Cent));
            InsertCentCommand = new Command(() => InsertMoney(Money.TenCent));
            InsertCentCommand = new Command(() => InsertMoney(Money.Quarter));
            InsertCentCommand = new Command(() => InsertMoney(Money.Dollar));
            InsertCentCommand = new Command(() => InsertMoney(Money.FiveDollar));
            InsertCentCommand = new Command(() => InsertMoney(Money.TwentyDollar));
        }

        private void InsertMoney(Money money) 
        {
            _snackMachine.InsertMoney(money);
            Notify("MoneyInTransaction");
        }
    }
}
