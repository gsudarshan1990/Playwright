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
}