namespace CW_W18.Models
{
    public class BankAccount
    {
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        private decimal _balance;
        public BankAccount(decimal InitialBalance)
        {
            _balance = InitialBalance;
        }
        public async Task<bool> WithDrawAsync(decimal amount)
        {
            return await Task.Run(() =>
            {
                if (_balance >= amount)
                {
                    _balance -= amount;
                    return true;
                }
                return false;
            });
        }
    }
}
