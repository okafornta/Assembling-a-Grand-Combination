/*TASK:
 * will show you how to assemble complex text via an example of 
 * a soccer match result
 */

// Data in variables
string country1 = "Qatar";
string country2 = "Ecuador";

int goals1 = 0;
int goals2 = 2;

//Output of the match result
Console.WriteLine(
    "Match - " + country1 + " vs " + country2 + 
    " end with result " + 
    goals1 + " : " + goals2 + ".");

// Waiting for Enter
Console.ReadLine();

/* DISCUSSION:
 * In the solution, you should especially note the following:

    • You are using variables with different data types to store different
    kinds of values.

    • You are constructing the displayed message from nine parts joined
    together by eigth plus signs. Some of the parts of the message are
    fixed, while the others are variable.
 */ 