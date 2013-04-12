var gAnswers = new Array();
var gAnswerNum = 0;

function ClearAnswerArray()
{
    for (i=0; i<gAnswers.length; i++)
        gAnswers[i] = false;
}

function CheckAnswers( nQuestions )
{
    var wrongAnswers;
    wrongAnswers=0;
    for (i=0; i<nQuestions; i++)
    {
        if (gAnswers[i] == false)
            wrongAnswers++;
    }
        // Todo - get API for sizeof gAnswers to do this right
    if (nQuestions > gAnswerNum)
        alert("Please answer all of the questions first!");
    else if (wrongAnswers == 0)
        alert("Congratulations!  You have 100% correct!");
    else
        alert("You have " + wrongAnswers + " incorrect answers :(");
}
function CorrectAnswer(index)
{
    gAnswers[index] = true;
    gAnswerNum++;
}
function IncorrectAnswer(index)
{
    gAnswers[index] = false;
    gAnswerNum++;
}
