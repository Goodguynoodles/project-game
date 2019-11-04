using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class story : MonoBehaviour
{

    private enum States
    {
        menu,
        gang1,
        kamer1a,
        kamer1b,
        kamer1c,
        kamer2a,
        kamer2b,
        kamer2c,
        gang2,
        kamer3a,
        kamer3b,
        kamer3c,
        kamer4a,
        kamer4b,
        kamer4c,
        gang3,
        kamer5a,
        kamer5b,
        kamer5c,
        kamer6a,
        kamer6b,
        kamer6c,
        gang4,
        kamer7a,
        kamer7b,
        kamer7c,
        kamer8,
        vraag1,
        vraag2,
        vraag3,
        vraag4,
        vraag5,
        vraag6,
        vraag7,
        sleutel1,
        sleutel2,
        sleutel3,
        sleutel4,
        sleutel5,
        sleutel6,
        sleutel7,
        slot1,
        slot2,
        slot3,
        slot4,
        gameover,
        end,
    }

    private States currentState = States.menu;


    public bool itTrue;
    public bool kamer2;
    public bool kamer3;
    public bool kamer4;
    public bool kamer5;
    public bool kamer6;
    public bool kamer7;
    public bool kamer1sec;
    public bool kamer2sec;
    public bool kamer3sec;
    public bool kamer4sec;
    public bool kamer5sec;
    public bool kamer6sec;
    public bool kamer7sec;
    // Start is called before the first frame update
    void Start()
    {
        showmainmenu();
        itTrue = true;
        kamer2 = true;
        kamer3 = true;
        kamer4 = true;
        kamer5 = true;
        kamer6 = true;
        kamer7 = true;
        kamer1sec = true;
        kamer2sec = true;
        kamer3sec = true;
        kamer4sec = true;
        kamer5sec = true;
        kamer6sec = true;
        kamer7sec = true;
    }

    void OnUserInput(string input)
    {
        if (input == "gamer")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("congratulations your a real gamer");
        }

        if (input == "menu")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        switch (currentState)
        {
            case States.menu:
                if (input == "")
                {
                    gang1();
                }
                else
                {
                    gang1();
                }

                break;
            
            case States.gang1:
                if (input == "feather")
                {
                    gang2();
                }

                if (kamer1sec)
                {
                    if (itTrue)
                    {
                        if (input == "1.21")
                        {
                            kamer1a();
                            kamer1sec = false;
                        }
                    }
                }
                else if (!itTrue)
                {
                    slot();
                    currentState = States.slot1;
                }
                else if (!kamer1sec)
                {
                    kamer1c();
                }

                if (kamer2sec)
                {
                    if (kamer2)
                    {
                        if (input == "1.22")
                        {
                            kamer2a();
                            kamer2sec = false;
                        }
                    }
                }
                else if (!kamer2sec)
                {
                    kamer2c();
                }
                else if (!kamer2)
                {
                    slot();
                    currentState = States.slot1;
                }
                else
                {
                    Terminal.WriteLine("type one of the options");
                }
                break;
            case States.kamer1a:
                if (input == "")
                {
                    kamer1b();
                }
                else
                {
                    kamer1b();
                }
                break;
            case States.kamer1b:
                if (input == "walk away")
                {
                    gang1();
                }
                else if (input == "answer")
                {
                    vraag1();
                    itTrue = false;
                }
                else
                {
                    Terminal.WriteLine("type one of the word you see above");
                }
                break;
            case States.kamer1c:
                if (input == "")
                {
                    kamer1b();
                }
                else
                {
                    kamer1b();
                }
                break;
            case States.vraag1:
                if (input == "motherboard")
                {
                    sleutel1();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type one of the answers");
                }
                else
                {
                    gameover();
                    currentState = States.gameover;
                }
                break;
            case States.sleutel1:
                if (input == "")
                {
                    gang1();
                }
                else
                {
                    gang1();
                }
                break;
            
            case States.kamer2a:
                if (input == "")
                {
                   kamer2b();
                }
                else
                { 
                    kamer2b();
                }
                break;
            case States.kamer2b:
                if (input == "walk away")
                {
                    gang1();
                }
                else if (input == "answer")
                {
                    vraag2();
                    kamer2 = false;
                } 
                break;
            case States.kamer2c:
                if (input == "")
                {
                    kamer2b();
                }
                else
                {
                    kamer2b();
                }
                break;
            case States.vraag2:
                if (input == "yes")
                {
                    sleutel2();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type one of the word you see above");
                }
                else
                {
                    gameover();
                }
                break;
            case States.sleutel2:
                if (input == "")
                {
                    gang1();
                }
                else
                {
                    gang1();
                }
                break;
            case States.gang2:
                if (input == "feather")
                {
                    gang3();
                }
                else if (input == "go back")
                {
                    gang1();
                }

                if (kamer3sec)
                {
                    if (kamer3)
                    {
                        if (input == "1.23")
                        {
                            kamer3a();
                            kamer3sec = false;
                        }
                    }
                }
                else if (!kamer3)
                {
                    slot();
                    currentState = States.slot2;
                }
                else if (!kamer3sec)
                {
                    kamer3c();
                }
                if (kamer4sec)
                {
                    if (kamer4)
                    {
                        if (input == "1.24")
                        {
                            kamer4a();
                            kamer4sec = false;
                        }
                    }
                }
                else if (!kamer4)
                {
                    slot();
                    currentState = States.slot2;
                }
                else if (!kamer4sec)
                {
                    kamer4c();
                }
                else
                {
                    Terminal.WriteLine("type gang2");
                }

                break;
            
            case States.kamer3a:
                if (input == "")
                {
                    kamer3b();
                }
                else
                {
                    kamer3b();
                }
                break;
            case States.kamer3b:
                if (input == "walk away")
                {
                    gang2();
                }
                else if (input == "answer")
                {
                    vraag3();
                    kamer3 = false;
                }
                else
                {
                    Terminal.WriteLine("type one of the word you see above");
                }

                break;
            case States.kamer3c:
                if (input == "")
                {
                    kamer3b();
                }
                else
                {
                    kamer3b();
                }
                break;
            case States.vraag3:
                if (input == "cascading style sheet")
                {
                    sleutel3();
                }    
                else if (input == "")
                {
                    Terminal.WriteLine("type een andwoord");
                }
                else
                {
                    gameover();
                    currentState = States.gameover;
                }
                break;
            case States.sleutel3:
                if (input == "")
                {
                    gang2();
                }
                else
                {
                    gang2();
                }
                break;
            
            case States.kamer4a:
                if (input == "")
                {
                   kamer4b();
                }
                else
                { 
                    kamer4b();
                }
                break;
            case States.kamer4b:
                if (input == "walk away")
                {
                    gang2();
                }
                else if (input == "answer")
                {
                    vraag4();
                    kamer4 = false;
                } 
                break;
            case States.kamer4c:
                if (input == "")
                {
                    kamer4b();
                }
                else
                {
                    kamer4b();
                }
                break;
            case States.vraag4:
                if (input == "2008")
                {
                    sleutel4();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type one of the word you see above");
                }
                else
                {
                    gameover();
                }
                break;
            case States.sleutel4:
                if (input == "")
                {
                    gang2();
                }
                else
                {
                    gang2();
                }
                break;

            case States.gang3:
                if (input == "feather")
                {
                    gang4();
                }
                else if (input == "go back")
                {
                    gang2();
                }

                if (kamer5sec)
                {
                    if (kamer5)
                    {
                        if (input == "kamer5")
                        {
                            kamer5a();
                            kamer5sec = false;
                        }
                    }
                }
                else if (!kamer5)
                {
                    slot();
                    currentState = States.slot3;
                }
                else if(!kamer5sec)
                {
                    kamer5c();
                }
                
                if (kamer6sec)
                {
                    if (kamer6)
                    {
                        if (input == "kamer6")
                        {
                            
                            kamer6a();
                            kamer6sec = false;

                        }
                    }
                }
                else if (!kamer6sec)
                {
                    kamer6c();
                    currentState = States.slot3;
                }
                else if (!kamer6)
                {
                    slot();
                }
                else if (!kamer6sec)
                {
                    
                }
                else
                {
                    Terminal.WriteLine("type gang2");
                }

                break;
            
            case States.kamer5a:
                if (input == "")
                {
                    kamer5b();
                }
                else
                {
                    kamer5b();
                }
                break;
            case States.kamer5b:
                if (input == "walk away")
                {
                    gang3();
                }
                else if (input == "answer")
                {
                    vraag5();
                    kamer5 = false;
                }
                break;
            case States.kamer5c:
                if (input == "")
                {
                    kamer5b();
                }
                else
                {
                    kamer5b();
                }
                break;
            case States.vraag5:
                if (input == "no")
                {
                    sleutel5();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type een andwoord");
                }
                else
                {
                    gameover();
                    currentState = States.gameover;
                }
                break;
            case States.sleutel5:
                if (input == "")
                {
                    gang3();
                }
                else
                {
                    gang3();
                }
                break;
            
            case States.kamer6a:
                if (input == "")
                {
                   kamer6b();
                }
                else
                { 
                    kamer6b();
                }
                break;
            case States.kamer6b:
                if (input == "walk away")
                {
                    gang3();
                }
                else if (input == "answer")
                {
                    vraag6();
                    kamer6 = false;
                } 
                break;
            case States.kamer6c:
                if (input == "")
                {
                    kamer6b();
                }
                else
                {
                    kamer6b();
                }
                break;
            case States.vraag6:
                if (input == "sql")
                {
                    sleutel6();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type one of the word you see above");
                }
                else
                {
                    gameover();
                }
                break;
            case States.sleutel6:
                if (input == "")
                {
                    gang3();
                }
                else
                {
                    gang3();
                }
                break;

            case States.gang4:
                if (input == "go back")
                {
                    gang3();
                }
                if (kamer7sec)
                {
                    if (kamer7)
                    {
                        if (input == "kamer7")
                        {
                            kamer7a();
                        }
                    }
                }
                else if (!kamer7)
                {
                    slot();
                    currentState = States.slot4;
                }
                else if (kamer7sec)
                {
                    kamer7c();
                }
                else if (input == "gang3")
                {
                    gang3();
                }

                if (input == "exit")
                {
                    kamer8();
                }
                else
                {
                    Terminal.WriteLine("type gang3 to ga back");
                }
                break;
            case States.kamer7a:
                if (input == "")
                {
                   kamer7b();
                }
                else
                {
                    kamer7b();
                }
                break;
            case States.kamer7b:
                if (input == "answer")
                {
                    vraag7();
                    kamer7 = false;
                }
                else if (input == "walk away")
                {
                    gang4();
                }
                break;
            case States.vraag7:
                if (input == "html")
                {
                    sleutel7();
                }
                else if (input == "")
                {
                    Terminal.WriteLine("type one of the word you see above");
                }
                else
                {
                    gameover();
                }
                break;
            case States.sleutel7:
                if (input == "")
                {
                    gang4();
                }
                else
                {
                    gang4();
                }
                break;
            case States.kamer8:
                if (input == "laptop")
                {
                    finish();
                }
                else if (input == "Laptop")
                {
                   finish(); 
                }
                else if (input == "LAPTOP")
                {
                    finish(); 
                }
                else if (input == "lAPTOP")
                {
                    finish(); 
                }
                else if (input == "go back")
                {
                    gang4();
                }
                else
                {
                    Terminal.ClearScreen();
                    Terminal.WriteLine("wrong code");
                }
                break;
            case States.slot1:
                if (input == "")
                {
                    gang1();
                }
                else
                {
                    gang1();
                }
                break;
            case States.slot2:
                if (input == "")
                {
                    gang2();
                }
                else
                {
                    gang2();
                }
                break;
            case States.slot3:
                if (input == "")
                {
                    gang3();
                }
                else
                {
                    gang3();
                }
                break;
            case States.slot4:
                if (input == "")
                {
                    gang4();
                }
                else
                {
                    gang4();
                }
                break;
            case States.gameover:
                if (input == "not a real gamer")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                }
                break;
        }
    }

    void showmainmenu()
    {
        Terminal.WriteLine("");
        Terminal.WriteLine("12:30 vrijdag middag");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have to stay for detention");
        Terminal.WriteLine("and you suddenly hear a noice");
        Terminal.WriteLine("on the broadcaster you hear that there is a bom in the");
        Terminal.WriteLine("school and you rush out of the class room and run");
        Terminal.WriteLine("to the exit but when you try to open");
        Terminal.WriteLine("the door is locked and when you look ");
        Terminal.WriteLine("back you see people in the class rooms");
    }

    void gang1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("gang1");
        Terminal.WriteLine("");
        Terminal.WriteLine("you are in the first part of the hallway");
        Terminal.WriteLine("and there are to class rooms to both side of you");
        Terminal.WriteLine("with the class room numbers 1.21 and 1.22");
        Terminal.WriteLine("you 3 options go feather to the next part");
        Terminal.WriteLine("of the hall way or go in to one of the class rooms");
        Terminal.WriteLine("");
        Terminal.WriteLine("> feather");
        Terminal.WriteLine("> 1.21");
        Terminal.WriteLine("> 1.22");
        currentState = States.gang1;
    }

    void kamer1a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.21");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to a class room and see a strange thing in the");
        Terminal.WriteLine("middle of the room looking at you with looks like eye's");
        Terminal.WriteLine("and on feather inspection it a robot");
        Terminal.WriteLine("its starts to speak in broken robotic voice");
        Terminal.WriteLine("it says: i have a qqqqquestion for yyyyyou");
        currentState = States.kamer1a;
    }

    void kamer1b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.21");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of teh room or try to answer it");
        Terminal.WriteLine("");
        Terminal.WriteLine("> walk away");
        Terminal.WriteLine("> answer");
        currentState = States.kamer1b;
    }

    void kamer1c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("lokaal 1.21");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk back in to the class room and the robot says");
        Terminal.WriteLine("welccccom back human");
        Terminal.WriteLine("yyyyyyyou want to answer the qqqqqquuestion now");
        currentState = States.kamer1c;
    }

    void kamer2a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.22");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room see a fat bastard of a man");
        Terminal.WriteLine("you hear him wheezing across the room");
        Terminal.WriteLine("you feel uneasy just looking at him gasping for air");
        Terminal.WriteLine("he tells you in a deep russian voice he says");
        Terminal.WriteLine("you there answer my question or i crush you");
        currentState = States.kamer2a;
    }

    void kamer2b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.22");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of tha class room or answer");
        Terminal.WriteLine("the question");
        Terminal.WriteLine("");
        Terminal.WriteLine("> answer");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer2b;
    }

    void kamer2c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.22");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk back in to the class room");
        Terminal.WriteLine("the fat bastard says to you");
        Terminal.WriteLine("you weak proof your self bij answering the question");
        currentState = States.kamer2c;
    }

    void gang2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("gang2");
        Terminal.WriteLine("");
        Terminal.WriteLine("you are in the second part of the hallway");
        Terminal.WriteLine("and there are to class rooms to both side of you");
        Terminal.WriteLine("with the class room numbers 1.23 and 1.24");
        Terminal.WriteLine("you 4 options go feather to the next part");
        Terminal.WriteLine("of the hall way or go in to one of the class rooms");
        Terminal.WriteLine("or to go back");
        Terminal.WriteLine("");
        Terminal.WriteLine("> feather");
        Terminal.WriteLine("> go back");
        Terminal.WriteLine("> 1.23");
        Terminal.WriteLine("> 1.24");
        currentState = States.gang2;
    }

    void kamer3a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("lokaal 1.23");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("and you see in the middle of the room");
        Terminal.WriteLine("man standing just a normal looking man");
        Terminal.WriteLine("you ask him why he is hear");
        Terminal.WriteLine("and he says in a happy tone to");
        Terminal.WriteLine("hi my name is norm and i am hear to sell");
        Terminal.WriteLine("you a vacuum cleaner but if you want to buy one");
        Terminal.WriteLine("you need to answer a simple question first");
        currentState = States.kamer3a;
    }
    void kamer3b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("lokaal 1.23");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have to 2 options walk out of the room or");
        Terminal.WriteLine("answer his question and buy a vacuum cleaner");
        Terminal.WriteLine("");
        Terminal.WriteLine("> buy");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer3b;
    }

    void kamer3c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("and norm says to you");
        Terminal.WriteLine("you back to buy a vacuum cleaner and answer");
        Terminal.WriteLine("the question");
        currentState = States.kamer3c;
    }

    void kamer4a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.24");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room and see a");
        Terminal.WriteLine("giant rat that look like a man standing");
        Terminal.WriteLine("in the corner when you try te get closer");
        Terminal.WriteLine("he runs to you like a rat and stops");
        Terminal.WriteLine("right in front of you and says");
        Terminal.WriteLine("can i ask you a question");
        currentState = States.kamer4a;
    }
    void kamer4b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.24");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of tha class room or answer");
        Terminal.WriteLine("the question");
        Terminal.WriteLine("");
        Terminal.WriteLine("> answer");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer4b;
    }

    void kamer4c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.24");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("the ratman says");
        Terminal.WriteLine("you back to answer my question");
        currentState = States.kamer4c;
    }
    void gang3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("gang3");
        Terminal.WriteLine("");
        Terminal.WriteLine("you are in the third part of the hallway");
        Terminal.WriteLine("and there are to class rooms to both side of you");
        Terminal.WriteLine("with the class room numbers 1.25 and 1.26");
        Terminal.WriteLine("you 3 options go feather to the next part");
        Terminal.WriteLine("of the hall way or go in to one of the class rooms");
        Terminal.WriteLine("");
        Terminal.WriteLine("> feather");
        Terminal.WriteLine("> go back");
        Terminal.WriteLine("> 1.25");
        Terminal.WriteLine("> 1.26");
        currentState = States.gang3;
    }

    void kamer5a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.25");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the  bio class room");
        Terminal.WriteLine("and you see know one");
        Terminal.WriteLine("but when you a bout to leave you");
        Terminal.WriteLine("hear a voice from the skeleton hanging");
        Terminal.WriteLine("i the class room he says");
        Terminal.WriteLine("can is qsk you a question");
        currentState = States.kamer5a;
    }
    void kamer5b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.25");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of tha class room or answer");
        Terminal.WriteLine("the question");
        Terminal.WriteLine("");
        Terminal.WriteLine("> answer");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer5b;
    }
    
    void kamer5c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.25");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("the skeleton says");
        Terminal.WriteLine("you back to answer my question");
        currentState = States.kamer5c;
    }

    void kamer6a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.26");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in the class room and see a woman");
        Terminal.WriteLine("with 9 fox tails standing in the class room");
        Terminal.WriteLine("she comes over to you and says");
        Terminal.WriteLine("can i ask you a question");
        currentState = States.kamer6a;
    }
    void kamer6b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.26");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of tha class room or answer");
        Terminal.WriteLine("the question");
        Terminal.WriteLine("");
        Terminal.WriteLine("> answer");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer6b;
    }

    void kamer6c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.26");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("the fox says");
        Terminal.WriteLine("you back to answer my question");
        currentState = States.kamer6c;
    }
    
    void gang4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("gang4");
        Terminal.WriteLine("");
        Terminal.WriteLine("you are in the fourth part of the hallway");
        Terminal.WriteLine("there is one class room next to you");
        Terminal.WriteLine("and there is a hallway that leads to a emergency exit");
        Terminal.WriteLine("but it has a keypad");
        Terminal.WriteLine("there is a note on the door in front of the hallway");
        Terminal.WriteLine("it says find de code to open in and on the back it says");
        Terminal.WriteLine("tip look in the class rooms");
        Terminal.WriteLine(" you have 3 options");
        Terminal.WriteLine("");
        Terminal.WriteLine("> go back");
        Terminal.WriteLine("> 1.21");
        Terminal.WriteLine("> exit");
        currentState = States.gang4;
    }

    void kamer7a()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.27");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room and see a clown");
        Terminal.WriteLine("standing in the middle of the room");
        Terminal.WriteLine("he walks to you but he struggles to get to you");
        Terminal.WriteLine("because he is wearing to big of them shoes");
        Terminal.WriteLine("when he gets over to you he says");
        Terminal.WriteLine("can i ask you a question and than he honks his nose");
        currentState = States.kamer7a;
    }

    void kamer7b()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.27");
        Terminal.WriteLine("");
        Terminal.WriteLine("you have 2 options walk out of tha class room or answer");
        Terminal.WriteLine("the question");
        Terminal.WriteLine("");
        Terminal.WriteLine("> answer");
        Terminal.WriteLine("> walk away");
        currentState = States.kamer7b;
    }
    
    void kamer7c()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("lokaal 1.27");
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk in to the class room");
        Terminal.WriteLine("the clown says");
        Terminal.WriteLine("you back to answer my question");
        currentState = States.kamer7c;
    }

    void kamer8()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you walk to the exit and see a digital lock");
        Terminal.WriteLine("");
        Terminal.WriteLine("type the code to exit or go back");
        Terminal.WriteLine("");
        Terminal.WriteLine("> type the code");
        Terminal.WriteLine("> go back");
        currentState = States.kamer8;
    }

    void gameover()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("game end");
        Terminal.WriteLine("type not a real gamer to restart");
        currentState = States.gameover;
    }

    void vraag1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("what is the most important hardware part of the pc");
        Terminal.WriteLine("");
        Terminal.WriteLine("> motherboard");
        Terminal.WriteLine("> graphics card");
        Terminal.WriteLine("> ram");
        Terminal.WriteLine("> processor");
        currentState = States.vraag1;
    }

    void vraag2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("is c# a programing language");
        Terminal.WriteLine("");
        Terminal.WriteLine("> yes");
        Terminal.WriteLine("> no");
        currentState = States.vraag2;
    }

    void vraag3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("what does the acronym css stand for");
        Terminal.WriteLine("");
        Terminal.WriteLine("> Cascading Style Sheet");
        Terminal.WriteLine("> Current Style Sheet");
        Terminal.WriteLine("> Case super succ");
        currentState = States.vraag3;
    }

    void vraag4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("when was python3 created");
        Terminal.WriteLine("");
        Terminal.WriteLine("> 2000");
        Terminal.WriteLine("> 2005");
        Terminal.WriteLine("> 2008");
        currentState = States.vraag4;
    }

    void vraag5()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("is swaft a programing language");
        Terminal.WriteLine("");
        Terminal.WriteLine("> yes");
        Terminal.WriteLine("> no");
        currentState = States.vraag5;
    }

    void vraag6()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("witch on of these programing language is used for databases");
        Terminal.WriteLine("");
        Terminal.WriteLine("> sql");
        Terminal.WriteLine("> java script");
        Terminal.WriteLine("> python");
        currentState = States.vraag6;
    }

    void vraag7()
    {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("with script is the front script for a website");
            Terminal.WriteLine("");
            Terminal.WriteLine("> css");
            Terminal.WriteLine("> java");
            Terminal.WriteLine("> html");
            currentState = States.vraag7;
    }

    void slot()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("you try to open the door but its lock't");
    }
    
    void sleutel1()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("you answered correctly your reward a key for the code");
            Terminal.WriteLine("key: L");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel1;
        }

        void sleutel2()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("je hebt het andwoord goed hier is een letter");
            Terminal.WriteLine("key: O");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel2;
        }

        void sleutel3()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("norm says to you");
            Terminal.WriteLine("you answer the question correctly");
            Terminal.WriteLine("now i will send you the vacuum it will arive in 2 weeks");
            Terminal.WriteLine("after he sad that you walk out of");
            Terminal.WriteLine("the room and the door shuts behind you");
            currentState = States.sleutel3;
        }

        void sleutel4()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("you answered correctly your reward a key for the code");
            Terminal.WriteLine("key: A");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel4;
        }

        void sleutel5()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("you answered correctly your reward a key for the code");
            Terminal.WriteLine("key: P");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel5;
        }

        void sleutel6()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("you answered correctly your reward a key for the code");
            Terminal.WriteLine("key: P");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel6;
        }

        void sleutel7()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("you answered correctly your reward a key for the code");
            Terminal.WriteLine("key: T");
            Terminal.WriteLine("");
            Terminal.WriteLine("after you answered correctly you leave the class room");
            Terminal.WriteLine("and go back to the hall way");
            currentState = States.sleutel7;
        }

        void finish()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("");
            Terminal.WriteLine("end");
            currentState = States.end;
        }
    
}