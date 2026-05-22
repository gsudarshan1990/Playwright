class BankAccount
{
    accountNumber:string;
    balance: number

    constructor(account:string, bal:number)
    {
        this.accountNumber=account
        this.balance = bal
    }

    deposit(amount:number)
    {
        this.balance+=amount
    }

    withdraw(amount:number)
    {
       if((this.balance-amount)<0 )
       {
            console.log("Insufficient Balance")
       }
       else{
        this.balance-=amount
       }
    }

    getBankDetails()
    {
        console.log("Account Number",this.accountNumber)
        console.log('Balance',this.balance)
    }
}

const bankaccount = new BankAccount("8213893112349",50000)
bankaccount.deposit(5000)
bankaccount.getBankDetails()
bankaccount.withdraw(20000)
bankaccount.getBankDetails()
