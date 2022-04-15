// See https://aka.ms/new-console-template for more information


class Customer
{
    private int customerId;

    public int CustomerId { get { return customerId; } set { customerId = value; } }
    private String customerName;
    public String CustomerName { get { return customerName; } set { customerName = value; } }

    private String emailId;
    public String EmailId { get { return emailId; } set { customerName = value; } }

    public Customer(int customerId, String customerName, String emailId)
    {
        this.customerId = customerId;
        this.customerName = customerName;
        this.emailId = emailId;
    }
}

