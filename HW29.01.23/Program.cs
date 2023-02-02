//---Метод функции Аккермана---
var GetAck(int n, int m){
    if(n > 4 && m > 2)
    {
        Console.Write($"Дважды подумай)");
    }
    return;
    if(n == 0)
    {
        return m + 1;
    }
    if(m == 0)
    {
        return (n - 1, 1);
    }
    else (Ack(n-1, Ack(n, m - 1)));
}
