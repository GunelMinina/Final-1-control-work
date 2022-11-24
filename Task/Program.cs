// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите длинну массива строк");

int numElements = int.Parse(Console.ReadLine());
string[] inputArray = FillArray(numElements);
string[] filteredArray = filterArray(inputArray);

Console.WriteLine("Итоговый массив:");
PrintArray(filteredArray);


string[] FillArray(int size){
    string[] filledArray = new string[size];
    for(int i = 0; i < filledArray.Length; i++){
        Console.WriteLine($"Введите {i}-й элемент массива");
       filledArray[i] = Console.ReadLine(); 
    }
    return filledArray;
}

void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }
}

string[] filterArray(string[] array){
    int newLength = 0;

    for(int i = 0; i < array.Length; i++){
      if (array[i].Length <= 3) {
        newLength++;
      }
    }

    string[] newArray = new string[newLength];
    int j = 0;
    for(int i = 0; i < array.Length; i++){
      if (array[i].Length <= 3) {
        newArray[j] = array[i];
        j++;
      }
    }
    return newArray;
}