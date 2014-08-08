#include <iostream>
using namespace std;

int main()
{
	int secondNow;
	int hours, minits, seconds;
	cout << "Enter seconds now: ";
	cin >> secondNow;
	hours = secondNow / 3600;
	minits = (secondNow - hours * 3600) / 60;
	seconds = secondNow % 60;
	cout << hours << ':' << minits << ':' << seconds << endl;
	return 0;
}
