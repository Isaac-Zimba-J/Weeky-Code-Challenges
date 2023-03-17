// #include <iostream>
// #include <algorithm>
// #include <list>


// using namespace std;


// // string sortList(string val)
// // {
// //     int mixList = {1,2,8,3,7,4,6,5,8,3,99,74,12,54,8,79,35}

// // }


// int main()
// {

//     std::list <int> mixList = {1,9,7,3,2,5,8,4,6,};
//     int array[9] = [];

// for (auto i = mixList.begin(); i != mixList.end() ; ++i)
// {
//    cout<<*i<<endl;
//    mixList.sort();
// array[i];
// }

//     return 0;
// }


// here we use std::list mainly because it has better performance in inserting, moving, and extracting
// elements from any position
// it also does better with algorithms that perform such operations intensitly 




#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

void SortList(string val) {

    vector<int> mixList = {1, 9, 2, 8, 3, 7, 4, 6, 5, 8, 3, 99, 74, 12, 54, 8, 79, 35};

    transform(val.begin(), val.end(), val.begin(), ::tolower);

    if (val == "asc") {
        sort(mixList.begin(), mixList.end());
        cout << "Your list in ascending order is : ";
        for (int i = 0; i < mixList.size(); i++) {
            cout << mixList[i] << " ";
        }
        cout << endl;
    }
    else if (val == "desc") {
        sort(mixList.begin(), mixList.end(), greater<int>());
        cout << "Your list in descending order is : ";
        for (int i = 0; i < mixList.size(); i++) {
            cout << mixList[i] << " ";
        }
        cout << endl;
    }
    else if (val == "none") {
        cout << "Your list as it was given : ";
        for (int i = 0; i < mixList.size(); i++) {
            cout << mixList[i] << " ";
        }
        cout << endl;
    }
    else {
        cout << "What you chose does not exist" << endl;
    }
}

int main() {
    while (true) {
        cout << "\n\nThank you for trying this code, please \n\nfollow and like for more such content and suggestions are welsome" << endl;
        string choice;
        cout << "\n\nEnter either 'asc', 'desc' or 'none' \nto get a list in ascending, descending or none : ";
        cin >> choice;
        SortList(choice);
    }
    return 0;
}
