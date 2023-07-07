// Необходимо перевести число из десятичной системы в двоичную.

int number =13;

void Perevod(int Decnumber)
{
    if(Decnumber <=0) return;
    Perevod(Decnumber/2);
    Console.Write(Decnumber%2);
}

Perevod(number);