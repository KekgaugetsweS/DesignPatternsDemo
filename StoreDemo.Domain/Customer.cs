namespace StoreDemo.Domain
{
    // All the code in this file is included in all platforms.
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
            throw new NotImplementedException("Not implemented");
        }
    }
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is Required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (BillAmount == 0)
            {
                throw new Exception("Bill Amount is Required");

            }
            if (BillDate >= DateTime.Today)
            {
                throw new Exception("Bill date is not proper");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
        }

    }
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is Required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
        }
    }

}