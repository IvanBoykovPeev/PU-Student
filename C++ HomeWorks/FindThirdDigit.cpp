#include<iostream>
using namespace std;

int main()
{
	//find third digit right to left
	int number;
	cout << "Enter number: ";
	cin >> number;
	int digit = number / 100 % 10;
	cout << "Third digit is:" << digit << endl;
	return 0;
}



