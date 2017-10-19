let n = 3;
let vector = [];
vector.length = n;

generate(vector, 0);

function generate(vector, index) {
    if (index >= vector.length)  {
        console.log(vector.join(''));
    } else {
        vector[index] = 0;
        generate(vector, index + 1);

        vector[index] = 1;
        generate(vector, index + 1);
    }
}