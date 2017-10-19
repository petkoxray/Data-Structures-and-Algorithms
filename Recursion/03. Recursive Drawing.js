let n = 5;

draw(n);

function draw(n) {
    if (n === 0)
        return;

    console.log('*'.repeat(n));

    draw(n - 1);
    
    console.log('#'.repeat(n));
}