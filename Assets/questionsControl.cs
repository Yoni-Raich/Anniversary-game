using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class questionsControl : MonoBehaviour {

    public List<string> listAsk = new List<string>();
    List<string> anser1 = new List<string>();
    List<string> anser2 = new List<string>();
    List<string> anser3 = new List<string>();

    List<string> randomButtons = new List<string>();

    public Text askText;
    public Text buttonText1;
    public Text buttonText2;
    public Text buttonText3;

    public Button button1;
    public Button button2;
    public Button button3;
    Button buttonColor;

    public GameObject panel;

    int NumToD;
    public int TakeNum = 0;

    bool isTrue;

    //order the all textes in a random.
    public void Order()
    {
        // TaceNum = Random.Range(0, listAsk.Count - 1);
        
        askText.text = listAsk[TakeNum];

        randomButtons.Clear();
        randomButtons.Add(anser1[TakeNum]);
        randomButtons.Add(anser2[TakeNum]);
        randomButtons.Add(anser3[TakeNum]);

        //Enter random text for Button num 1
        NumToD = Random.Range(0, randomButtons.Count);
        buttonText1.text = randomButtons[NumToD];
        randomButtons.RemoveAt(NumToD);

        //Enter random text for Button num 2
        NumToD = Random.Range(0, randomButtons.Count);
        buttonText2.text = randomButtons[NumToD];
        randomButtons.RemoveAt(NumToD);

        //Enter the lest textIndex from buttonText list for Button num 3
        buttonText3.text = randomButtons[0];


        button1.image.color = Color.white;
        button2.image.color = Color.white;
        button3.image.color = Color.white;

       
    }

    //input the all asks and asnsers.
    void Start()
    {
        

        listAsk.Add("?לט תחפשמ לש םיעוריאב הניכמ דימת אמא לכאמ הזיא");
        anser1.Add(".תוקרי תדיטשפ");
        anser2.Add("ןיכהל לאינדמ תשקבמ איה הלש הפקה תא וליפא לכוא הלשיב אל םלועמ אמא");
        anser3.Add(".ופוט תמראווש");

        listAsk.Add(".אבא לש תולכירדא תנכותה תא קילדהל בשחמל חקול ןמז המכ");
        anser1.Add(".הבכתמ אוה זא יכ .עצמאב בשחמה תא חקית אל הענש ללפתהלו שארמ ןמז רתויש המכ קילדהל יאדכ .עודי אל ןמז");
        anser2.Add(".הקדמ תוחפ םג םימעפל םומיסקמ תוקד 2");
        anser3.Add(".םכילא דיספמ ינאו תוקד עבש");

        listAsk.Add(".ןופלטב ןמז הברה יכה תרבדמ אמא ימ םא");
        anser1.Add(".םהמ הזיא תואדווב תעדל השק הלש םיחאה םא");
        anser2.Add(".בתכמה תא האיבה רבכ הנויה םע תלאושו תלבלבתמ םימעפל ןיידע איה השעמל .ןופלטב הרביד אל םלועמ אמא");
        anser3.Add(".יילפ רשוכ לש גיצנה םע");

        listAsk.Add(".ןפרחתמ יכה אבא הממ");
        anser1.Add(".תונוכנ תובושתה לכ");
        anser2.Add(".חבטמבש בבותסמה אסכה תא םתס םיבבוסמשכ");
        anser3.Add("קולד ןגזמהשכ תוחותפ תותלד םיריאשמשכ");

        listAsk.Add(".היחא םע תרבדמ איהשכ תשמתשמ אמא תומשהמ הזיא");
        anser1.Add(".'לוקצאח");
        anser2.Add(".יקזח");
        anser3.Add(".לאקזחי");

        listAsk.Add(".םכלבשיב קחצי והימ");
        anser1.Add(".תונוכנ תובושתה לכ");
        anser2.Add(".הטמלמ סעוכ םויה לכש אוהה ןכשה");
        anser3.Add(".םיעסונ ךיא גשומ ול ןיא סלכת לבא הגיהנ הרומ אוהש אמא לש דוד");

        listAsk.Add(".שער רתוי השוע ימ");
        anser1.Add(".םימואתה");
        anser2.Add(".ןוליס סוטמ");
        anser3.Add(".לכסותמ דלי לש תלד תקירט");

        listAsk.Add(".תבש לכ רוזחי אבא הלאש הזיא");
        anser1.Add(".ןושאר םויב לכאנו טנושטה תא איפקה ינא בוט");
        anser2.Add("?סקטג תשבל זא ונ");
        anser3.Add(".הזרמ דאמ בוהצ לבא םייניעה תא יל שיגדמ ארונ דורו יכ דורו וא בוהצ ףידע םייברג הזיא");

        listAsk.Add(".תיבב רסח דימת המ");
        anser1.Add(".סקורקו םינעטמ");
        anser2.Add("ךופ תוכימשו סננא");
        anser3.Add(".דלקושו םיתות תופצרמ הקנמ חלמ יימ");

        listAsk.Add("'פאצאוו' תואטבל הסנמ איהשכ אתבס לש רתוי תקייודמה הסריגה המ");
        anser1.Add(".פא'צאו");
        anser2.Add(".הלחתאב חתפ םע פצאוו");
        anser3.Add(".הרבחב תוינמ וליפא הל שי םשב התעט אל םלועמ אתבס");

        listAsk.Add(".הלודגה תירכה תכייש (!)תמאב ימל");
        anser1.Add(".ינוי רמול הצור ינא ינוי רבכ דיגת ונ");
        anser2.Add(".םייחל-ש רורב");
        anser3.Add(".רזח אל םלועמ אהו .רוזחיש דע תירכה לע ול רומשנש שקיב קלדב קפד םעפש ןקז דחא שיאל");

        listAsk.Add(".הריש םע הנושארה השיגפל תונכהב תכל קיחרה ינוי המכ דע");
        anser1.Add(".הענ ותוחא םע השיגפ םייבו השיגפה םייקתהל התייה הרומא םש ןולמל עסנ");
        anser2.Add(".רתוי ותוא הצרת הריש הככש ןימאה יכ הנושארה השיגפל ללכב עיגה אל תמאה תאו הגשהל השק תאצל הצר ינוי");
        anser3.Add(".ךיתח אוה המכ םעפ ידימ הל שוחלל םירצלמה תא חירכהו ןולמה לכ תא רכש אוה");

        listAsk.Add(".לצינש לוכאל יללל םורגי המ");
        anser1.Add("התמה התפוג לע");
        anser2.Add(".תרכומ ריהמ-ןוזמ תשרל םינוילימב רכמנש ירוקמ ןוכתמ וליפא הל שיו םילצינש לע הלוח ילל");
        anser3.Add(".הפי שקבנ םא");

        listAsk.Add(".תוכבל םייחל םרוג המ");
        anser1.Add(".ל'וחמ םירזוחשכ");
        anser2.Add(".וילע םילכתסמ םהשכ םיכוב םישנא השעמל הכב אל םלועמו רערועמ יתלבה רבגה אוה םייח");
        anser3.Add("!?לצב …גשומ יל ןיא");

        listAsk.Add(".בירל קיספהל םימואתל םורגי המ");
        anser1.Add(".הניש ךותמ ובר םהינשו הלילה עצמאב םהלש רדחה דיל םעפ יתרבע .רבד םוש");
        anser2.Add(".הלאשמב ודלונש םיכיסנ ינש םה םואתפ המ !?םימואתה");
        anser3.Add(".תוקד המכל סופתי הז .קוחר קורזלו ןופלטה תא םהל תחקל");

        listAsk.Add("יגבאפב בוט תמאב ינוי המכ דע");
        anser1.Add("סעכת אל הרישש ידכ ידימ טרפל הצור אל ינאו קחשמה לש רערועמ יתלבה ךלמה ינוי");
        anser2.Add("טיינטרופב קר קחשמ ינוי");
        anser3.Add(".תועטב ותוא החצינו יגבאפ הקילדה בויטויב םינוטרס תוארל םוקמב תוער םעפש עורג ךכ לכ ינוי");

        listAsk.Add(".ינש לש רישה לש ירוקמה ןחלה אוה המ");
        anser1.Add("(הפ יתישע המ םתנבה ...וליאכ םינשה)םינשה ךלהמב דבא ירוקמה ןחלה");
        anser2.Add(".הפי תא המכ שוקינש שוקינש");
        anser3.Add("הל-ינש תאז הל-ינש תאז");



        Order();

    }

    public void Button_1_Click()
    {
        
        if (buttonText1.text == anser1[TakeNum])
        {
            button1.image.color = Color.gray;
            button2.image.color = Color.white;
            button3.image.color = Color.white;
            isTrue = true;
            buttonColor = button1;


        }
        else
        {
            button1.image.color = Color.gray;
            button2.image.color = Color.white;
            button3.image.color = Color.white;
            //   FalseQest();
            isTrue = false;
            buttonColor = button1;

        }
    }
    public void Button_2_Click()
    {
        if (buttonText2.text == anser1[TakeNum])
        {
            button1.image.color = Color.white;
            button3.image.color = Color.white;
            button2.image.color = Color.gray;
            buttonColor = button2;
            isTrue = true;
            

        }
        else
        {

            button2.image.color = Color.gray;
            button1.image.color = Color.white;
            button3.image.color = Color.white;
            //  FalseQest();
            isTrue = false;
            buttonColor = button2;

        }

    }
    public void Button_3_Click()
    {
        if (buttonText3.text == anser1[TakeNum])
        {
            button3.image.color = Color.gray;
            button1.image.color = Color.white;
            button2.image.color = Color.white;
            isTrue = true;
            buttonColor = button3;
        }
        else
        {
            button3.image.color = Color.gray;
            button1.image.color = Color.white;
            button2.image.color = Color.white;
            // FalseQest();
            isTrue = false;
            buttonColor = button3;

        }
    }

    public bool TrueQuest()
    {
        return isTrue;
   
    }
    public Button ColorButton()
    {
        return buttonColor;
    }
}
