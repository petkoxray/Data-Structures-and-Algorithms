let arr = [1, 2, 3, 4, 5];

console.log(sum(arr, 0));

function sum(arr, index) {
    if (index === arr.length - 1)
        return arr[index];
    else
        return arr[index] + sum(arr, index + 1);
}