namespace ByteBank {
    public class Account {
        public Account(int agency, int number) {
            Account.TotalAccounts++;

            this.Agency = agency;
            this.Number = number;
        }

        private double _balance;

        public static int TotalAccounts { get; private set; }

        public Client Owner { get; set; }

        public int Agency { get; set; }

        public int Number { get; set; }

        public double Balance {
            get {
                return _balance;
            }
            set {
                if (value < 0) {
                    return;
                }

                _balance = value;
            }
        }

        public bool WithDraw(double value) {
            if (value <= 0 || value > this._balance) {
                return false;
            }

            this._balance -= value;
            return true;
        }

        public void Deposit(double value) {
            if (value <= 0) {
                return;
            }

            this._balance += value;
        }

        public bool Transfer(double value, Account destinyAccount) {
            if (value <= 0 || value > this._balance) {
                return false;
            }

            this.WithDraw(value);
            destinyAccount.Deposit(value);

            return true;
        }
    }
}
