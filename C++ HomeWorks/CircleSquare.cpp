#include <iostream>
#define M_PI       3.14159265358979323846
using namespace std;

int main()
{
	double radius;
	cout << "Enter the radius: ";
	cin >> radius;
	if (radius > 0)
	{
		double square;
		square = M_PI * radius * radius;
		cout << "Square= " << square << endl;
	}
	return 0;
}
