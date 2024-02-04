string[] initialArray = new string[] {"Hello", "2", "World", ":-)","Ура"};
string[] createdArray = new string [initialArray.Length];
int createdIndex = 0;

for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <=3)
    {
        createdArray[createdIndex] = initialArray[i];
        createdIndex++;
    }
}

for (int i = 0; i < createdIndex; i++)
{
    Console.WriteLine(createdArray[i]);
}
