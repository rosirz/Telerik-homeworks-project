function solve(args)
{
    let lines = args.length / 4,
        linesArray = [];
    for (let i = 0; i < lines; i++)
    {
        linesArray[i] = {
            firstX: +args[i*4],
            firstY: +args[i*4 + 1],
            secondX: +args[i*4 + 2],
            secondY: +args[i*4 + 3],
            a: function (){ return this.firstX - this.secondX},
            b: function () { return Math.abs(this.firstY - this.secondY)},
            length: function () { return Math.sqrt(Math.pow(this.a, 2) + Math.pow(this.b, 2))}
        };
        // let a = Math.abs(linesArray[i].firstX - linesArray[i].secondX),
        //     b = Math.abs(linesArray[i].firstY - linesArray[i].secondY),
        //     sumLength = Math.sqrt(Math.pow(a, 2) + Math.pow(b, 2));
        // linesArray[i].sumLength = sumLength.toFixed(2);
    }
    for (let i = 0; i < lines; i++)
    {
        console.log(linesArray[i].length());
    }
}

solve ([
  '5', '6', '7', '8',
  '1', '2', '3', '4',
  '9', '10', '11', '12'
]);