
//            создай новый массив в котором будет 10 элементов
int[] array = new int[10];
// по умолчанию он будет заполнен нулями

// метод заполняет массив случайными числами
void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// метод который будет печатать массив
void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
        Console.WriteLine(col[position]);
        position++;
    }
    // в void методе оператор return не используется
}

FillArray(array);
PrintArray(array);

//=============================================================

int[] array = new int[10];

void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while (position < count){
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет будет -1
    while (index < count){
        if (collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);






