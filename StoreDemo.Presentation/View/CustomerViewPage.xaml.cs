using StoreDemo.Domain;

using StoreDemo.Infrastructure;
namespace StoreDemo.Presentation;

public partial class CustomerViewPage : ContentPage
{

	private CustomerBase cust = null;
    private Customer customer = null;
    private Lead lead = null;
	public CustomerViewPage()
	{
		InitializeComponent();

		custType.Items.Add("Customer");
		custType.Items.Add("Lead");
        
		
	}

    

    private void custType_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Desgin pattern :- RIP replace if with  Poly
        cust = Factory.Create(custType.Items[custType.SelectedIndex]);
    }


    private void setCustomer()
    {
        cust.CustomerName = CustomerNameEntry.Text;
        cust.PhoneNumber = PhoneNumberEntry.Text;
        cust.BillAmount = Convert.ToDecimal(BillAmountENtry.Text);
        cust.BillDate = Convert.ToDateTime(BillDateEntry.Text);
        cust.Address = AddressEntry.Text;
    }
    private void btnValidate_Click_Clicked(object sender, EventArgs e)
    {
        
        try
        {
            setCustomer();
            cust.Validate();
        }
        catch (Exception ex)
        {
            DisplayAlert("Warning", ex.Message.ToString(), "Ok");
        }
    }
}