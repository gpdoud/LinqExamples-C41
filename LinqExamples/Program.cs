int[] ints = {
    803, 755, 892, 877, 292, 636, 929, 688, 430, 175,
    664, 210, 299, 380, 317, 744, 971, 125, 240, 292,
    672, 132, 474, 654, 991, 630, 945, 676, 904, 538,
    197, 733, 368, 431, 337, 945, 888, 511, 435, 830,
    817, 527, 288, 131, 390, 788, 776, 826, 235, 894,
    252, 941, 981, 215, 292, 235, 271, 756, 921, 178,
    858, 425, 646, 702, 278, 379, 977, 556, 434, 447,
    200, 181, 735, 812, 271, 479, 343, 491, 633, 679,
    673, 436, 204, 770, 965, 798, 881, 149, 906, 190,
    578, 333, 464, 607, 910, 887, 249, 261, 631, 896
};

// Calculate the Min, Max, and Average

var min = ints.Min();
var max = ints.Max();
var avg = ints.Average();
Console.WriteLine($"{min}, {max}, {avg}");

// Sum the number with odd number hundreds digits

var result = (from i in ints
             where (i >= 100 && i < 200)
                || (i >= 300 && i < 400)
                || (i >= 500 && i < 600)
                || (i >= 700 && i < 800)
                || (i >= 900 && i < 1000) 
              select i).Sum();
//Console.WriteLine(result);

// List all ints greater than the average of all ints

var greaterInts = from i in ints
                  where i > ints.Average()
                  orderby i
                  select i;
greaterInts.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();