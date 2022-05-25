// See https://aka.ms/new-console-template for more information


//create variable with starting number for the value
int number = 10;

Countdown();

//Recursive function that decriments the 'number' by one. The If statement will return when the number reaches 1.
void Countdown()
{
    
    Console.WriteLine(number);
    if (number == 1)
    {
        return;
    }
    else
    {
        number--;
        Countdown();
    }

}
