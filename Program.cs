
string[] FindLessThan(string[] input, int n) {
    string[] output = new string[CountLess(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
int CountLess(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}


string[] array = AskArray();
string[] ResultArray= FindlessThan(array,3);