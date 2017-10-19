let set = [1, 2, 3, 4];
let k = 2;
let combinations = [];
combinations.length = k;

generate(set, combinations, 0, 0);

function generate(set, combinations, index, border) {
    if (index > combinations.length - 1) {
        console.log(combinations.join(''));
    } else {
        for (let i = border; i < set.length; i++) {
            combinations[index] = set[i];
            generate(set, combinations, index + 1, i + 1);
        }
    }
}