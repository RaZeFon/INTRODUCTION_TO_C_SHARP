
int[] array = {1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length; //возвращает длину или количество элементов
int find = 4;
int index = 0;
while (index < n){
    if (array[index] == find){
        Console.WriteLine(index); //покажет индекс где элементы совпали
    }
    index++;
}

//=====================================================================

int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};
int n = array.Length; //возвращает длину или количество элементов
int find = 18;
int index = 0;
while (index < n){
    if (array[index] == find){
        Console.WriteLine(index); //покажет индекс где элементы совпали
        break; //теперь будет искаться только 1 совпавший элемент
    }
    index++;
}



