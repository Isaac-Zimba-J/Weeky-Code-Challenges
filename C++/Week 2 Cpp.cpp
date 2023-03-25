#include <iostream>
#include <vector>
#include <tuple>
#include <algorithm>
#include <cmath>

using namespace std;

tuple<int, int> SumZero(vector<int> lst) {
    int smallValueOne = lst[0];
    int bigValueTwo = lst[1];
    vector<tuple<int, int>> finalPair = { make_tuple(smallValueOne, bigValueTwo) };

    for (int i = 2; i < lst.size(); i++) {
        if (abs(lst[i]) < abs(smallValueOne)) {
            bigValueTwo = smallValueOne;
            smallValueOne = lst[i];
            finalPair = { make_tuple(smallValueOne, bigValueTwo) };
        } else if (abs(lst[i]) < abs(bigValueTwo)) {
            bigValueTwo = lst[i];
            finalPair.push_back(make_tuple(smallValueOne, bigValueTwo));
        }
    }

    return *min_element(finalPair.begin(), finalPair.end(),
        [](auto &left, auto &right) {
            return abs(get<0>(left) + get<1>(left)) < abs(get<0>(right) + get<1>(right));
        });
}

int main() {
    vector<int> myList = {1, 3, 7, -9, -3, 7, 8, 9, 3, 5};
    auto result = SumZero(myList);
    cout << get<0>(result) << " " << get<1>(result) << endl;
    return 0;
}
