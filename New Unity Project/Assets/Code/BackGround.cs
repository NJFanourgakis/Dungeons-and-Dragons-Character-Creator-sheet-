using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class BackGround : MonoBehaviour
{
    public setterinfo si;       // infor holder class
    public GameObject PT;       // personality button
    public GameObject ideal;    // ideal button
    public GameObject bond;     // bond button
    public GameObject flaw;     // flaw button
    public Button other;        // other option button
    public GameObject back;     // back button
    public GameObject Pright;   // the right panel
    public Dropdown options1;   // 1st dropdown for options in background
    public Dropdown options2;   // 2nd dropdown for options in background
    public Dropdown options3;   // 3rd dropdown for options in background
    public Text backgroundtxt;  // titled for the background
    public Text options1txt;    // text of the 1st option
    public Text options2txt;    // text of the 2nd option
    public Text options3txt;    // text of the 3rd option
    private string[] personalitys = new string[8]; // array list of the personality options
    private string[] ideals = new string[6];      // array list of idleas options
    private string[] bonds = new string[6];       // array list of bonds options
    private string[] flaws = new string[6];       // array list of flaws options
    public Button[] choices = new Button[8];      // set your choses of button in an array
    private float h ; // hight for the button
    private int number; // tell me what array list im look at 
    private string[] selction = new string[4];
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < selction.Length; i++)
        {
            selction[i] = "null";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void personality()
    {
        number = 0;
        PT.active = false;
        ideal.active = false;
        bond.active = false;
        flaw.active = false;
        other.gameObject.active = false;
        back.active = true;
        backgroundtxt.text = "Personalities";
        setPersonality(si.getbg());
        setButtonsOn(personalitys);
       
    }
    public void actionideal()
    {
        number = 1;
        PT.active = false;
        ideal.active = false;
        bond.active = false;
        flaw.active = false;
        other.gameObject.active = false;
        back.active = true;
        backgroundtxt.text = "Ideals";
        setIdeal(si.getbg());
        setButtonsOn(ideals);
    }
    public void actionbonds()
    {
        number = 2;
        PT.active = false;
        ideal.active = false;
        bond.active = false;
        flaw.active = false;
        other.gameObject.active = false;
        back.active = true;
        backgroundtxt.text = "Bonds";
        setBonds(si.getbg());
        setButtonsOn(bonds);
    }
    public void actionflaws()
    {
        number = 3;
        PT.active = false;
        ideal.active = false;
        bond.active = false;
        flaw.active = false;
        other.gameObject.active = false;
        back.active = true;
        backgroundtxt.text = "Flaws";
        setFlaw(si.getbg());
        setButtonsOn(flaws);
    }
    public void actionother()
    {
        number = 4;
        PT.active = false;
        ideal.active = false;
        bond.active = false;
        flaw.active = false;
        other.gameObject.active = false;
        back.active = true;
        backgroundtxt.text = "Others";
        setother(si.getbg());
    }
    public void backaction()
    {
        PT.active = true;
        ideal.active = true;
        bond.active = true;
        flaw.active = true;
        other.gameObject.active = true;
        back.active = false;
        options1.gameObject.SetActive(false);
        options2.gameObject.SetActive(false);
        options3.gameObject.SetActive(false);
        backgroundtxt.text = "Background";
        options1txt.gameObject.SetActive(false);
        options2txt.gameObject.SetActive(false);
        options3txt.gameObject.SetActive(false);
        for (int q = 0; q < choices.Length; q++)
        {
            choices[q].gameObject.active = false;
        }

    }
    
    void countlines(string a) 
    {
        h = 0;
        for (int i =0; i<a.Length;i++)
        {
            if(a[i] == '\n')
            {
               h++;
            }
        }
        h = 30 + h * 15;
    }
    void setPersonality(string person)
    {
        switch (person)
        {
            case "Acolyte":
                {
                    personalitys[0] = "I idolize a perticular hero of my faith, and constantly\n" +
                        "refer to that person's deeds and example.";
                    personalitys[1] = "I can find common ground between the fiercest\n" +
                        "enemies, empathizing with them and always working\n" +
                        "toward peace.";
                    personalitys[2] = "I see omens in every event and action. The gods try to\n" +
                        "speak to us, we just need to listen.";
                    personalitys[3] = "Nothing can shake my optimistic attitude.";
                    personalitys[4] = "I quote (or misquote) sacred text and proverbs in\n" +
                        "almost every situation.";
                    personalitys[5] = "I am tolerant (or intolerant) of other faiths and respect\n" +
                        "(or condemn) the worship of other gods.";
                    personalitys[6] = "I've enjoyed fine food, drink, and high society among\n" +
                        "my temple's elite. Rough living grates on me.";
                    personalitys[7] = "I've spent so long in the temple that I have little\n" +
                        "practical experience dealing wih people in the outside\n" +
                        "world";

                    break;
                }
            case "Charlatan":
                {
                    personalitys[0] = "I fall in and out of love easily, and am always pursuing\n" +
                        "someone.";
                    personalitys[1] = "I have a joke for every occasion, especially occasions\n" +
                        "where humor is inpproriate.";
                    personalitys[2] = "Flattery is preferred trick for getting what I want.";
                    personalitys[3] = "I'm a born gambler who can't resist taking a risk for a\n" +
                        "potential payoff";
                    personalitys[4] = "I lie about almost everthing, even when there's no\n" +
                        "good reason to.";
                    personalitys[5] = "Sarcasm and insults are my weapons of choice.";
                    personalitys[6] = "I keep multiple holy symbols on me and invoke\n" +
                        "whatever deity might come in useful at any given\n" +
                        "monent.";
                    personalitys[7] = "I pocket anything I see that might have some value.";
                    break;
                }
            case "Criminal":
                {
                    personalitys[0] = "I always have a plan for what to do when things go\n" +
                        "wrong.";
                    personalitys[1] = "I am always calm, no mater what the situation. I never\n" +
                        "raise my voice or let my emotions control me.";
                    personalitys[2] = "The first thing I do in a new place is note thelocations\n" +
                        "of everything caluable - or where such things could be\n" +
                        "hidden.";
                    personalitys[3] = "I would rather make a new friend than a new enemy.";
                    personalitys[4] = "I am incredibly slow to trust. Those who seem the\n" +
                        "fairest often have the most to hide.";
                    personalitys[5] = "I don't pay attention to the risks in a situation. Never\n" +
                        "tell me the odds.";
                    personalitys[6] = "The best way to get me to do something is to tell me I\n" +
                        "can't do it.";
                    personalitys[7] = "I blow up at the slightest insult.";
                    break;
                }
            case "Entertainer":
                {
                    personalitys[0] = "I know a story relevant to almost every situation.";
                    personalitys[1] = "When ever I come to a new place, I collect local rumors\n" +
                        "and spread gossip.";
                    personalitys[2] = "I'm a hopeless romantic, always searching for that\n" +
                        "special someone.";
                    personalitys[3] = "Nobody stats angry at me or around mre for long,since\n" +
                        "I can defuse any amount of tension.";
                    personalitys[4] = "I love a good insult, even one directed at me.";
                    personalitys[5] = "I get bitter if I'm not the center of attection.";
                    personalitys[6] = "I'll settle for nothing less then perfection.";
                    personalitys[7] = "I change m mood or my mind as quickly as I change\n" +
                        "key in a song.";
                    break;
                }
            case "Folk Hero":
                {
                    personalitys[0] = "I judge peple by their actions, not their words.";
                    personalitys[1] = "If someone is trouble, I'm always ready to lend help.";
                    personalitys[2] = "When I set my mind to something , I follow throught no\n" +
                        "matter what gets in my way.";
                    personalitys[3] = "I have a strong sense of fair play and always try to find\n" +
                        "the most equitable solution to arguments.";
                    personalitys[4] = "I'm confident in my own abilities and do what I can to\n" +
                        "install confidence in others.";
                    personalitys[5] = "Thinking is for other people. I prefer action.";
                    personalitys[6] = "I misuse long words in an attempt to sound smarter.";
                    personalitys[7] = "I get bored easily.When am I going to get on with my\n" +
                        "destiny?";
                    break;
                }
            case "Guild Artisan":
                {
                    personalitys[0] = "I believe that anything worth doing is worth doing\n" +
                        "right. I can't help it - I'm a perfectionist.";
                    personalitys[1] = "I'm  a snob who looks down on those who can't\n" +
                        "appreciate fine art.";
                    personalitys[2] = "I always want to know how things work and what\n" +
                        "make people tick.";
                    personalitys[3] = "I'm full of witty aphorisms and have a proverb for\n" +
                        "every occasion.";
                    personalitys[4] = "I'm rude to peple who lack my commitment to hard\n" +
                        "work and fair play.";
                    personalitys[5] = "I like to talk at length about my profession.";
                    personalitys[6] = "I don't part with my money easily and will haggle\n" +
                        "tirelessly to get the best deal possible.";
                    personalitys[7] = "I'm well known for my work, and I want to make sure\n" +
                        "everyone appreciates it. I'm always taken aback when\n" +
                        "people haven't heard of me.";
                    break;
                }
            case "Hermit":
                {
                    personalitys[0] = "I've been isolated for so long that I rrely speak,\n" +
                        "preferring gestures and the occsional grunt.";
                    personalitys[1] = "I am utterly seren, even in the face of disster.";
                    personalitys[2] = "The leader of my community had something wise\n" +
                        "to say on every topic, and I am eager to share\n" +
                        "that wisdom.";
                    personalitys[3] = "I feel tremendous empathy for all who suffer.";
                    personalitys[4] = "I'm oblivious to etiquette and social expectations.";
                    personalitys[5] = "I connect everything that happens to me to a grand,\n" +
                        "cosmic plan.";
                    personalitys[6] = "I often get lost in my own thoughts and contemplation,\n" +
                        "becoming oblivious to my surroundings.";
                    personalitys[7] = "I am working on a grand philosophical theory and love\n" +
                        "sharing my ideas.";
                    break;
                }
            case "Noble":
                {
                    personalitys[0] = "My eloquent flattery makes everyone I talk to feel\n" +
                        "like the most wonderful and important person in the \n" +
                        "world.";
                    personalitys[1] = "The common folk love me for m kindness and\n" +
                        "generosity.";
                    personalitys[2] = "No one could doubt by looking at my regal bearing that\n" +
                        "I am a cut about the unwashed masses.";
                    personalitys[3] = " I take great pains to always look my best and follow the\n" +
                        "laest fashions.";
                    personalitys[4] = "I don't like get my hands dirty, and I won't be caught\n" +
                        "dead in unsuitable accommodations.";
                    personalitys[5] = "Despite my noble birth, I do not place myself above\n" +
                        "other folk. We all have the same blood.";
                    personalitys[6] = "My favor, once lost, is lost forever.";
                    personalitys[7] = "If you do me an injury, I will crush you, ruin your name,\n" +
                        "and salt your fields.";
                    break;
                }
            case "Outlander":
                {
                    personalitys[0] = "I'm driven by a wanderiust that led me away\n" +
                        "from home.";
                    personalitys[1] = "I watch over my friends as if they were a litter of\n" +
                        "newborn pups.";
                    personalitys[2] = "I once ran twenty-five miles without stopping to warn\n" +
                        "to my clan of an approaching orc horde. I'd do it again\n" +
                        "if I had to.";
                    personalitys[3] = "I have a lesson for every situation, drawn from\n" +
                        "observing nature.";
                    personalitys[4] = "I place no stock in wealthy or well-mannered folk\n" +
                        "Money and manners won't save you from a hungry\n" +
                        "owlbear.";
                    personalitys[5] = "I'm always picking things up, absently fiddling with\n" +
                        "them, and sometimes accidentally breakingthem.";
                    personalitys[6] = "I feel far more comfortable around animals than\n" +
                        "people.";
                    personalitys[7] = "I was, in fact, raised by wolves.";
                    break;
                }
            case "Sage":
                {
                    personalitys[0] = "I use polysyllabic words that convey the impression of\n" +
                        "great erudition.";
                    personalitys[1] = "I've read every book in the world's greatest libraries-\n" +
                        "or I like to boast that I have.";
                    personalitys[2] = "I'm used to helping out those who aren't as smart as I\n" +
                        "am, and I patiently explain anything and everything to \n" +
                        "others.";
                    personalitys[3] = "There's nothing I like more than a good mystery.";
                    personalitys[4] = "I'm willing to listen to every side of an argument before\n" +
                        "I make my own judgment.";
                    personalitys[5] = "I ... speak ... slowly ... when talking ... to idiots ...\n" +
                        "whick ... almost .. everyone ... is ... compared ...\n" +
                        "to me.";
                    personalitys[6] = "I am horribly, horribly awkward in social situations.";
                    personalitys[7] = "I'm convinced that people are always trying to steal my\n" +
                        "secrets.";
                    break;
                }
            case "Sailor":
                {
                    personalitys[0] = "My friends know they can rely on me, no matter what.";
                    personalitys[1] = "I work hard so that I can play hard when the work\n" +
                        "is done";
                    personalitys[2] = "I enjoy sailing into new ports and making new friends\n" +
                        "over a flagon of ale.";
                    personalitys[3] = "I stretch the truth for the sake of a good story.";
                    personalitys[4] = "To me, a tevern brawl is a nice way to get to know a\n" +
                        "new city";
                    personalitys[5] = "I never pass up a friendly wager.";
                    personalitys[6] = "My language is as foul as an otyugh nest.";
                    personalitys[7] = "I like a job well done, especially if I can convince\n" +
                        "someone else to do it.";
                    break;
                }
            case "Soldier":
                {
                    personalitys[0] = "I'm alway polite and respectful.";
                    personalitys[1] = "I'm haunted by memories of war. I can't get the images\n" +
                        "of violence out of my mind.";
                    personalitys[2] = "I've lost too many friends, and I'm slow to make new\n" +
                        "ones.";
                    personalitys[3] = "I'm full of inspiring and cautionary tales from my\n" +
                        "military experience relevant to almost every combat\n" +
                        "situation.";
                    personalitys[4] = "I can stare down a hell hound without flinching.";
                    personalitys[5] = "I enjoy being strong and like breaking things.";
                    personalitys[6] = "I have a crude sense of humor.";
                    personalitys[7] = "I fave problems head-on. A simple, direct solution is\n" +
                        "the best path to success.";
                    break;
                }
            case "Urchin":
                {
                    personalitys[0] = "I hide scraps of food and trikets away in my pockets.";
                    personalitys[1] = "I ask a lot of questins.";
                    personalitys[2] = "I like to squeeze into small places where no one else\n" +
                        "can get to me.";
                    personalitys[3] = "I sleep with my back to a wall or tree, with everthing I\n" +
                        "own wrapped in a bundle in my arms.";
                    personalitys[4] = "I eat like a pig and have bad manners.";
                    personalitys[5] = "I think anyone who;s nice to me is hiding evil intent.";
                    personalitys[6] = "I don't like a bathe.";
                    personalitys[7] = "I bluntly say what other people are hinting at or hiding.";
                    break;
                }
        }
    }
    void setIdeal (string person)
    {
        switch (person)
        {
            case "Acolyte":
                {
                    ideals[0] = "Tradition. The ancient traditions of worship and\n" +
                        "secrifice must be preserved and upheld. (Lawful)";
                    ideals[1] = "Charity. I always tr to help those in need no mater\n" +
                        "what the personal cost. (Good)";
                    ideals[2] = "Change. We must help bring about the changes the\n" +
                        "gods are constantly working in the world. (Chaotic)";
                    ideals[3] = "Power. I hope to one rise to the top of my faith's\n" +
                        "religious hierarchy. (Lawful)";
                    ideals[4] = "Faith. I trust that my deity will guide my actions. I have\n" +
                        "faith that if I work hard, things will go well. (Lawful)";
                    ideals[5] = "Aspiration. I seek to prove myself worthy of my god's\n" +
                        "favor by matching my actions against his or her\n" +
                        "teachings. (Any)";
                    break;
                }
            case "Charlatan":
                {
                    ideals[0] = "Independece. I am a free spirit - no one tells me what\n" +
                        "to do. (Chaotic)";
                    ideals[1] = "Fairness. I never target people who can't afford to lose\n" +
                        "a few coins. (Lawful)";
                    ideals[2] = "Charity. I distribute the money I acquire to the people\n" +
                        "who really need it. (Good)";
                    ideals[3] = "Creativity. I never run the sme con twice. (Chaotic)";
                    ideals[4] = "Friendship. Material goods come and go. Bonds of\n" +
                        "friendship last forever. (Good)";
                    ideals[5] = "I'm determinded to make something\n" +
                        "of myslf. (Any)";
                    break;
                }
            case "Criminal":
                {
                    ideals[0] = "Honor. I don't steal from others in the trade. (Lawful)";
                    ideals[1] = "Freedom. Chains are meant to be broken, as are those\n" +
                        "who would forge them. (Chaotic)";
                    ideals[2] = "Charity. I steal from the wealthy so that I can help\n" +
                        "people in need. (Good)";
                    ideals[3] = "Greed. I will do whatever it takes to become\n" +
                        "wealty. (Evil)";
                    ideals[4] = "People. I'm loyal to my friends, not to any ideals, and\n" +
                        "everyone else can take a trip down the Styx for all I\n" +
                        "care. (Neutral)";
                    ideals[5] = "Redemption. There's a spark of good in everyone.\n" +
                        "(Good)";
                    break;
                }
            case "Entertainer":
                {
                    ideals[0] = "Beauty. When I perform, I make the world better than\n" +
                        "it was. (Good)";
                    ideals[1] = "Tradition. The stories, legends , and songs of the past\n" +
                        "must never be forgotten, for they teach us who we\n" +
                        "are. (Lawful)";
                    ideals[2] = "Creativity. The world is in need of new ideas and bold\n" +
                        "action. (Chaotic)";
                    ideals[3] = "Greed. I'm onlu in it for the money and game. (Evil)";
                    ideals[4] = "People. I like seeing the smiles on people's faces when\n" +
                        "I perform. That's all that matters. (Neutral)";
                    ideals[5] = "Honesty. Art should reflect the soul; it should come\n" +
                        "from within and reeal who we really are. (Any)";
                    break;
                }
            case "Folk Hero":
                {
                    ideals[0] = "Respect. People deserve to be treated with diginity and\n" +
                        "respect. (Good)";
                    ideals[1] = "Fairness. No one should get preferential treatment\n" +
                        "before the law, and no one is above the law. (Lawful)";
                    ideals[2] = "Freedom. Tryrants must not be allowed to oppress the\n" +
                        "people. (Chaotic)";
                    ideals[3] = "Might. If I become strong, I can take what I want -\n" +
                        "what I deserve. (Evil)";
                    ideals[4] = "Sincerity. Ther's no good in pretending to bo \n" +
                        "something I'm not. (Neutral)";
                    ideals[5] = "Destiny. Nothing and no one can steer me away from\n" +
                        "my higher calling. (Any)";
                    break;
                }
            case "Guild Artisan":
                {
                    ideals[0] = "Community. It is the duty of all civilized people to\n" +
                        "strengthen the bonds of community and the security\n" +
                        "of civilization. (Lawful)";
                    ideals[1] = "Generosity. My Talents were given to me so that I caould\n" +
                        "use them to benefit the world. (Good)";
                    ideals[2] = "Freedom. Everyone should be free to pursue his or her\n" +
                        "own livelihood. (Chaotic)";
                    ideals[3] = "Greed. I'm only in it for hte money. (Evil)";
                    ideals[4] = "People. I'm committed to the people I care about, not\n" +
                        "to ideals. (Nautral)";
                    ideals[5] = "Aspiration. I work hard to be the best there is at\n" +
                        "my craft. (Any)";
                    break;
                }
            case "Hermit":
                {
                    ideals[0] = "Greater Good. My gifts are meant to be shared with all,\n" +
                        "not used for my own benefit. (Good)";
                    ideals[1] = "Logic. Emotions myst not cloud our sense of what is\n" +
                        "right and true, or our logical thinking. (Lawful)";
                    ideals[2] = "Free Thinking. Inquiry and curiosity are the pillars of\n" +
                        "progress. (Chaotic)";
                    ideals[3] = "Power. Solitude and contemplation are paths toward\n" +
                        "mystical or magical power. (Evil)";
                    ideals[4] = "Live and let live. Medding in the affairs of others only\n" +
                        "causes trouble. (Neitral)";
                    ideals[5] = "Self-Knowledge. If you know yourself, there's nothing\n" +
                        "left to know. (Any)";
                    break;
                }
            case "Noble":
                {
                    ideals[0] = "Respect. Respect is due to me because of my position,\n" +
                        "but all peple regardless of station seserve to be\n" +
                        "treated with dignity. (Good)";
                    ideals[1] = "Responsibility. It is my duty to respect the autority of\n" +
                        "those aboce me, just as those below me must respect\n" +
                        "mine. (Lawful)";
                    ideals[2] = "Independence. I must prove that I can handle myself\n" +
                        "without the coddling of my family. (Chaotic)";
                    ideals[3] = "Power. If I can attain more power, no one will tell me\n" +
                        "what to do. (Evil)";
                    ideals[4] = "Family. Blood runs thicker than water. (Any)";
                    ideals[5] = "Noble Obligation. It is my dity to protect and core for\n" +
                        "the people beneath me. (Good)";
                    break;
                }
            case "Outlander":
                {
                    ideals[0] = "Change. Life is like the seasons, in cnostant change,\n" +
                        "and we must change with it. (Chaotic)";
                    ideals[1] = "Greater Good. It is each person's responsibility to\n" +
                        "make the most happiness for the whole tribe. (Good)";
                    ideals[2] = "Honor. If I dishonor myself, I dishonor my whole\n" +
                        "clan. (Lawful)";
                    ideals[3] = "Might. The strongest are meant to rule. (Evil)";
                    ideals[4] = "Nature. The natural world is more important that all\n" +
                        "the constructs of civilzation. (Neutral)";
                    ideals[5] = "Glory. I must earn glory in battle, for myself and\n" +
                        "my clan. (Any)";
                    break;
                }
            case "Sage":
                {
                    ideals[0] = "Knowledge. The path to power and self-improvement\n" +
                        "is throught knowledge. (Neutral)";
                    ideals[1] = "Beauty. What is beautiful ponts us beyond itself\n" +
                        "toward what is true. (Good)";
                    ideals[2] = "Logic. Emotions must not cloud our logical thinking.\n" +
                        "(Lawful)";
                    ideals[3] = "No Limits. Nothing should fetter the infinite possibility\n" +
                        "inherent in all existence. (Chaotic)";
                    ideals[4] = "Power. Knowledge is the path to power and\n" +
                        "dominiation. (Evil)";
                    ideals[5] = "Self-Improvement. The goal of a life of study is the\n" +
                        "betterment of oneself. (Any)";
                    break;
                }
            case "Sailor":
                {
                    ideals[0] = "Respect. The thing that keeps a ship together is mutal\n" +
                        "respect between captain and crew. (Good)";
                    ideals[1] = "Fairness. We all do the work, so we all share in the\n" +
                        "rewards. (Lawful)";
                    ideals[2] = "Freedom. The sea is freedom-the freedom to go\n" +
                        "anywhere and do anything. (Chaotic)";
                    ideals[3] = "Mastery. I'm a predator, and the other ship on the sea\n" +
                        "are my prey. (Evil)";
                    ideals[4] = "People. I'm committed to my crewmates, not to ideals.\n" +
                        "(Neutral)";
                    ideals[5] = "Aspiration. Someday I'll own my own ship and chart\n" +
                        "my own destiny. (Any)";
                    break;
                }
            case "Soldier":
                {
                    ideals[0] = "Creater Good. Our lot is to lay down our lives in\n" +
                        "defense of others. (Good)";
                    ideals[1] = "Responsibility. I do what I must and obey just\n" +
                        "authority. (Lawful)";
                    ideals[2] = "Independence. When people follow orders blidnly, they\n" +
                        "embrace a kind of tryanny. (Chaotic)";
                    ideals[3] = "Might. In life as in war, the stronger force wins. (Evil)";
                    ideals[4] = "Live and let Live. Ideals aren't worth killing over or\n" +
                        "going to war for. (Neutral)";
                    ideals[5] = "Nation. My city,nation, or people are all that matter. (Any)";
                    break;
                }
            case "Urchin":
                {
                    ideals[0] = "Respet. All people, rich or poor, deserve respect. (Good)";
                    ideals[1] = "Community. We have to take care of eah other,\n" +
                        "because no one else is going to do it. (Lawful)";
                    ideals[2] = "Change. The low are liftedup, and the high and mighty\n" +
                        "are brought down. Change is the nature of things. (Chaotic)";
                    ideals[3] = "Retribution. The rich need to be shown what life and\n" +
                        "death are like in the gutters. (Evil)";
                    ideals[4] = "People. I help the people who help me - that's what\n" +
                        "keeps us alive. (Neutral)";
                    ideals[5] = "Aspiration. I'm going to prove that I'm worthy of a\n" +
                        "better life. (Any)";
                    break;
                }
        }
    }
    void setBonds(string person)
    {
        switch (person)
        {
            case "Acolyte":
                {
                    bonds[0] = "I woudl di to recover an ancient relic of my faith that\n" +
                        "was lost long ago.";
                    bonds[1] = "I will someday get revenge on the corrupt temple\n" +
                        "hirarchy who branded me a heretic.";
                    bonds[2] = "I owe my life to the priest who took me in when my\n" +
                        "parents died.";
                    bonds[3] = "Everything I do is for the common people.";
                    bonds[4] = "I will do anything to protect the temple where I served.";
                    bonds[5] = "I seek to preserve a sacred text that my enemies\n" +
                        "consider heretical and seek to destroy.";
                    break;
                }
            case "Charlatan":
                {
                    bonds[0] = "I fleeced the wrong person and must work to ensure\n" +
                        "that this individual never crosses paths with me or\n" +
                        "those I care about.";
                    bonds[1] = "I owe everthing to my mentor- a horrible person\n" +
                        "who's probably rotting in jail somewhere.";
                    bonds[2] = "Somewhere ot there, I have a child who doesn't\n" +
                        "know me. I'm making the world better hor him or her.";
                    bonds[3] = "I come from a nonle family, and one day I'll reclaim my\n" +
                        "lands and title from those who stole them from me.";
                    bonds[4] = "A powerful person killed someone I love. Some day\n" +
                        "soon, I'll have my revenge.";
                    bonds[5] = "I swindled and ruined a person who didn't deserve it. I\n" +
                        "seek to atone for my misdeeds but might never be able\n" +
                        "to forgive myself.";
                    break;
                }
            case "Criminal":
                {
                    bonds[0] = "I'm trying to pay off an old debt I owe to a generous\n" +
                        "benefactor.";
                    bonds[1] = "My ill-gotten gains go to support my family.";
                    bonds[2] = "Something important was taken from me, and I aim to\n" +
                        "steal it back.";
                    bonds[3] = "I will become the greatest thief that ever lived.";
                    bonds[4] = "I'm guilty of a terrible crime. I hope I can redeem\n" +
                        "myself for it.";
                    bonds[5] = "Someone I loced died because of I mistake I made.\n" +
                        "That will never happed again.";
                    break;
                }
            case "Entertainer":
                {
                    bonds[0] = "My instrument is my most treasured possession, and it\n" +
                        "reminds me of someone I love.";
                    bonds[1] = "Someone stole my precious instrument, and someday\n" +
                        "I'll get it back.";
                    bonds[2] = "I want to be famous, what ever it takes.";
                    bonds[3] = "I idolize a hero of the old tales and measure my deeds\n" +
                        "against that peron's";
                    bonds[4] = "I wil do anything to prove myself superior to my hated\n" +
                        "rival.";
                    bonds[5] = "I would do anything for the other members of my\n" +
                        "old troupe.";
                    break;
                }
            case "Folk Hero":
                {
                    bonds[0] = "I have a family, but I have no idea where they are. One\n" +
                        "day, I hope to see them again.";
                    bonds[1] = "I worked the land, I love that land, and I will protect the\n" +
                        "land.";
                    bonds[2] = "A proud noble once gave me a horrible beating, and I\n" +
                        "will take my revenge on any bully I encounter.";
                    bonds[3] = "My tools are symbols of my past life, and I carry them\n" +
                        "so that I will never forget my roots.";
                    bonds[4] = "I protect those who cannot protect themselves.";
                    bonds[5] = "I wish my childhood sweetheart had come with me to\n" +
                        "pursue my destiny";
                    break;
                }
            case "Guild Artisan":
                {
                    bonds[0] = "The workshop where I learned my trade is the most\n" +
                        "important place in the world to me.";
                    bonds[1] = "I created a great work from someone, and then found\n" +
                        "them unworthy to receive it. I'm still looking for\n" +
                        "someone worthy.";
                    bonds[2] = "I owe my guild a great debt for forging me into the\n" +
                        "person I am today.";
                    bonds[3] = "I pursue wealth to secure someone's love.";
                    bonds[4] = "One day I will return to my guild and prove that I am\n" +
                        "the greatest artisan of them all.";
                    bonds[5] = "I will get revenge on the evil forces that destroyed my\n" +
                        "place of business and ruined my livelihood";
                    break;
                }
            case "Hermit":
                {
                    bonds[0] = "Nothing is more important that the other members of\n" +
                        "my hermitage, order or association.";
                    bonds[1] = "I entered seclusion to hide from the ones who might\n" +
                        "still be hunting me. I must someday confront them.";
                    bonds[2] = "I'm still seeking the enlightenment I pursed in my\n" +
                        "seclusion, and it still eludes me.";
                    bonds[3] = "I entered seclusion becuase I loved someone I could\n" +
                        "not have.";
                    bonds[4] = "Should my discovery come to light, it could bring ruin to\n" +
                        "the world.";
                    bonds[5] = "My isolation gave me great isight into a great evil that\n" +
                        "only I can destroy.";
                    break;
                }
            case "Noble":
                {
                    bonds[0] = "I will face any challenge to win the approval of my\n" +
                        "family.";
                    bonds[1] = "My house's alliance with another noble family\n" +
                        "must be sustained at all costs.";
                    bonds[2] = "Nothing is more important that the other meners\n" +
                        "of my family.";
                    bonds[3] = "I am in love wit the feir of a family that my family\n" +
                        "despises.";
                    bonds[4] = "My loyalty to my sovereign is uwavering.";
                    bonds[5] = "The common folk must see me as a hero of the people.";
                    break;
                }
            case "Outlander":
                {
                    bonds[0] = "My family,clan or tribe is the most important thing in\n" +
                        " my life, even when they are far from me.";
                    bonds[1] = "An injury to the unspoiled wilderness of my home is an\n" +
                        "injury to me.";
                    bonds[2] = "I will bring terrible wrath down on the evildoers who\n" +
                        "destroyed my homeland.";
                    bonds[3] = "I am the last of my tribe, and it is up to me to ensure\n" +
                        "their names enter legend.";
                    bonds[4] = "I suffer awful visions of a coming disaster and will do\n" +
                        "anuthing to prevent it.";
                    bonds[5] = "It is my dity to provide childen to sustain m tribe.";
                    break;
                }
            case "Sage":
                {
                    bonds[0] = "It is my duty to protect my students";
                    bonds[1] = "I have an ancient text that holds terrible secrets that\n" +
                        "mst not fall into the wrong hands.";
                    bonds[2] = "I work to preserve a library, university, scriptorium,\n " +
                        "or monastery.";
                    bonds[3] = "My life's work is a series of romes related to a specific\n" +
                        "field of lore.";
                    bonds[4] = "I've been searching my whole life for the answer to a\n" +
                        "certain suestion.";
                    bonds[5] = "I sold my soul for knowlede . I hope to do freat deeds\n" +
                        "and win it back.";
                    break;
                }
            case "Sailor":
                {
                    bonds[0] = "I'm loyal to my capain first, everything else second.";
                    bonds[1] = "the ship is most important- crewmates and captaons\n" +
                        "come and go.";
                    bonds[2] = "I'm always remember my first ship.";
                    bonds[3] = "In a barbor twon, I have a peramour whose eyes nearly\n" +
                        "stole me from the sea.";
                    bonds[4] = "I was cheated out of my fair share of the profits, and I\n" +
                        "want to get my due.";
                    bonds[5] = "Ruthless pirates mudered my captain and crewmates,\n" +
                        "pundered our ship and left me to die. Vengeance will\n" +
                        "be mine.";
                    break;
                }
            case "Soldier":
                {
                    bonds[0] = "I would still lay down my life for the people I\n" +
                        "served with."; 
                    bonds[1] = "Someone saved my life on the battlefield. To this day, I\n" +
                        "will never leace a friend behind.";
                    bonds[2] = "My honor is my life.";
                    bonds[3] = "I'll never forget the crushing defeat my company\n" +
                        "suffered or the enemies who dealt it.";
                    bonds[4] = "those who fight beside me are those worth dying for.";
                    bonds[5] = "I fight for those who cannot fight for themselces.";
                    break;
                }
            case "Urchin":
                {
                    bonds[0] = "My town or city is my home, and I'll fight to defend it.";
                    bonds[1] = "I sponsor an orphanage to keep others from enduring\n" +
                        "what I was forced to endure.";
                    bonds[2] = "I owe my survival to another urchin who taught me to\n" +
                        "live on the streets.";
                    bonds[3] = "I owe a debt I never repay to the person who took\n" +
                        "pity on me.";
                    bonds[4] = "I escaped my life of poverty by robbing an important\n" +
                        "person, and I'm wanted for it.";
                    bonds[5] = "No one else should bave to endure the hardships I've\n" +
                        "been through";
                    break;
                }
        }
    }
    void setFlaw(string person)
    {
        switch (person)
        {
            case "Acolyte":
                {
                    flaws[0] = "I judge others harshly, and myself even more severely.";
                    flaws[1] = "I put too much trust in those who wield power within\n" +
                        "my temple's hierarchy";
                    flaws[2] = "My piety some times leads me to blindly trust those\n" +
                        "that profess faith in my god.";
                    flaws[3] = "I am inflexible in my thinking.";
                    flaws[4] = "I am suspocious of strangers and expect the worst of\n" +
                        "them";
                    flaws[5] = "Once I pick a goal, I become obsessed with it to the \n" +
                        "detriment of everything else in my life.";
                    break;
                }
            case "Charlatan":
                {
                    flaws[0] = "I can't resist a pretty face.";
                    flaws[1] = "I'm always in debt. I spend my ill-gotten gains on\n" +
                        "decadent lucuries faster than I bring them in..";
                    flaws[2] = "I'm convinced that no one could ever fool me the way\n" +
                        "I fool others.";
                    flaws[3] = "I'm too greedy for my own good. I can't resist taking a \n" +
                        "risk if there's money involved.";
                    flaws[4] = "I can't resist swindling people who are more poerful\n" +
                        "than me.";
                    flaws[5] = "I hate to admit it and will hate myself for it, but i'll run\n" +
                        "and preserce my own hide if the going get tough.";
                    break;
                }
            case "Criminal":
                {
                    flaws[0] = "Whin I see something valuable, I can't think about\n" +
                        "anything but how to steal it.";
                    flaws[1] = "When faced with a choise between money and my\n" +
                        "friends, I usually choose the money.";
                    flaws[2] = "If there's a plan, I'll forget it. If i don't forgetit, I'll\n" +
                        "ignore it.";
                    flaws[3] = "I have a tell that reveals when I'm lying";
                    flaws[4] = "I turn tail and run when things look bad.";
                    flaws[5] = "An innocent person is in prison for a crime that I\n" +
                        "committed. I'm okay with that.";
                    break;
                }
            case "Entertainer":
                {
                    flaws[0] = "I'll do anything to win fame and renown.";
                    flaws[1] = "I'm a sucker for a pretty face.";
                    flaws[2] = "A scandel prevents mr from every going home again.\n" +
                        "That kind of trouble seems to follow me around.";
                    flaws[3] = "I once satirized a noble who still wants my head. It was\n" +
                        "a mistak that I will likely repeat.";
                    flaws[4] = "I have trouble keeping my true feelings hidden. My\n" +
                        "sharp tongue lands me in trouble.";
                    flaws[5] = "Despite my best efforts, I am unreliable to my friends.";
                    break;
                }
            case "Folk Hero":
                {
                    flaws[0] = "The tyrant who rules my land will stop at nothing to\n" +
                        "see me killed.";
                    flaws[1] = "I'm convinced of the significance of my destiny, and\n" +
                        "blind to my shortcomings and the risk of failure.";
                    flaws[2] = "The people who knew me when I was Young know my\n" +
                        "shameful secret, so I can never go home again.";
                    flaws[3] = "I have a weakness for the vices of the city, especially\n" +
                        "hard drink.";
                    flaws[4] = "Secretly, I believe that things would be better if I were a\n" +
                        "tyrantt lording over th land.";
                    flaws[5] = "I have trouble trusting in my allies.";
                    break;
                }
            case "Guild Artisan":
                {
                    flaws[0] = "I'll do anything to get my hands on something rare or\n" +
                        "priceless.";
                    flaws[1] = "I'm quick to assume that someone is trying to cheat\n" +
                        "me";
                    flaws[2] = "No one must ever learn that I once stole money from\n" +
                        "guild coffers.";
                    flaws[3] = "I'm never satisfied with shat I have - I always want\n" +
                        "more.";
                    flaws[4] = "I would kill to acquire a noble title.";
                    flaws[5] = "I'm horribly jealous of anyone who can outshine my\n" +
                        "handiwork. Everywhere I go, I surrounded by rivals.";
                    break;
                }
            case "Hermit":
                {
                    flaws[0] = "Now that I've returned to the world, I enjoy its delights\n" +
                        "a little too much.";
                    flaws[1] = "I harbor dark, bloodthirsty thoughts that my isolation\n" +
                        "and meditation failed to quell.";
                    flaws[2] = "I am dogmatic in my thoughts and philosophy.";
                    flaws[3] = "I let my need to win arguments overshadow\n" +
                        "friendships and harmony.";
                    flaws[4] = "I'd risk too much to uncover a lost bit of knowledge";
                    flaws[5] = "I like keeping secrets and won't share them with\n" +
                        "anyone.";
                    break;
                }
            case "Noble":
                {
                    flaws[0] = "I secretly believe that evryone is beneath me.";
                    flaws[1] = "I hide a truly scandalous secret that could ruin my\n" +
                        "family forever.";
                    flaws[2] = "I too often hear veiled insults and threats in every word\n" +
                        "addressed to me, and I'm quick to anger.";
                    flaws[3] = "I have an isatiable desire for carnal pleasures.";
                    flaws[4] = "In face, the world does revolce around me.";
                    flaws[5] = "By my wors and actions, I often bring shame to\n" +
                        "my family.";
                    break;
                }
            case "Outlander":
                {
                    flaws[0] = "I am too enamored of ale, wine, and other intoxicants.";
                    flaws[1] = "Ther's no room for caution in a life lived to the fullest.";
                    flaws[2] = "I remember every insult I've received and nurse a silent\n" +
                        "resentment toward anyone who's ever wronged me";
                    flaws[3] = "I am slow to trust members of other races, tribes, and\n" +
                        "societies.";
                    flaws[4] = "Violence is my answer to alost any challenge.";
                    flaws[5] = "Don't expect me to save those who can't save\n" +
                        "themselves. It is nature's way that the strong thrive\n" +
                        "and the weak perish.";
                    break;
                }
            case "Sage":
                {
                    flaws[0] = "I am easly distracted by the promise of information.";
                    flaws[1] = "Most people scream and run when they see a demon. I\n" +
                        "stop and take notes on it anatomy.";
                    flaws[2] = "Unlocking an ancient mystery is worth the price of a\n" +
                        "civilization";
                    flaws[3] = "I overlook obvious solutions ifavor of complicated\n" +
                        "ones.";
                    flaws[4] = "I speak without really thinking through my words,\n" +
                        "invariably insulting others.";
                    flaws[5] = "I can't keep a secret to save my life, or anyone else's.";
                    break;
                }
            case "Sailor":
                {
                    flaws[0] = "I follow order, even if I think they're wrong.";
                    flaws[1] = "I'll say anything to avoid having to do extra work.";
                    flaws[2] = "Once someone questions my courage, I never back\n" +
                        "down no matter how dangerous the situation.";
                    flaws[3] = "Once I start drinking, it's hard for me to stop.";
                    flaws[4] = "I can't help but pocket loose coins and other trinkets I\n" +
                        "come across.";
                    flaws[5] = "My pride will probably lead to my destruction.";
                    break;
                }
            case "Soldier":
                {
                    flaws[0] = "The monstrous enemy we faced in battle still leaves\n" +
                        "me quivering with fear.";
                    flaws[1] = "I have little respect for anyone who is not a\n" +
                        "proven warrior.";
                    flaws[2] = "I made a terrible mistake in battle that cost many lives,\n" +
                        "and I would do anything to keep that mistake secret.";
                    flaws[3] = "My hatred of my enemies is blind and unreasoning.";
                    flaws[4] = "I obey the law, even if the law causes misery";
                    flaws[5] = "i'd rather eat my armor than admit when I'm wrong.";
                    break;
                }
            case "Urchin":
                {
                    flaws[0] = "If I'm outnumbered, I will run away from a fight.";
                    flaws[1] = "Gold seems like a lot of money to me, and I'll do just\n" +
                        "about anything for more of it.";
                    flaws[2] = "I will never fully trust anyone other than myself.";
                    flaws[3] = "I'd rather kill someone in their sleep than fight fair.";
                    flaws[4] = "It's not stealing if I need it more than someone else.";
                    flaws[5] = "People who can't take care of themselves get what they\n" +
                        "deserve.";
                    break;
                }
        }
    }
    void setother(string person)
    {
        switch (person)
        {
            case "Acolyte":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    options2txt.gameObject.SetActive(true);
                    options2txt.text = "Pick another Language";
                    options2.gameObject.SetActive(true);
                    Language(options2);
                    checkLanguage(options2);
                    break;
                }
            case "Charlatan":
                {
                    options3txt.gameObject.SetActive(true);
                    options3txt.text = "Pick a Con";
                    options3.gameObject.SetActive(true);
                    options3.options.Add(new Dropdown.OptionData() { text = "Ten stoppered bottles filled with colored liquid" });
                    options3.options.Add(new Dropdown.OptionData() { text = "A set of weighted sice" });
                    options3.options.Add(new Dropdown.OptionData() { text = "A deck of marked cards" });
                    options3.options.Add(new Dropdown.OptionData() { text = "A signet ring of an imaginary duke" });
                    
                    options2txt.gameObject.SetActive(true);
                    backgroundtxt.text = "Pick a Scam";
                    options2.gameObject.SetActive(true);
                    choices[0].GetComponentInChildren<Text>().text = "I cheat at games of chance.";
                    choices[1].GetComponentInChildren<Text>().text = "I shave coins or forge documents";
                    choices[2].GetComponentInChildren<Text>().text = "I insinuate myself into people's lives to prey on their weakness and secure their fortunes.";
                    choices[3].GetComponentInChildren<Text>().text = "I put on new identities like clothes.";
                    choices[4].GetComponentInChildren<Text>().text = "I run sleight-of-hend cons on street corners.";
                    choices[5].GetComponentInChildren<Text>().text = "I convince people that wortthless junk is worth their\n" +
                        "hard-earned money.";
                    break;
                }
            case "Criminal":
                {
                    break;
                }
            case "Entertainer":
                {
                    break;
                }
            case "Guild Artisan":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    break;
                }
            case "Hermit":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    break;
                }
            case "Noble":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    break;
                }
            case "Outlander":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    break;
                }
            case "Sage":
                {
                    options1txt.gameObject.SetActive(true);
                    options1txt.text = "Pick a Language";
                    options1.gameObject.SetActive(true);
                    Language(options1);
                    checkLanguage(options1);
                    options2txt.gameObject.SetActive(true);
                    options2txt.text = "Pick another Language";
                    options2.gameObject.SetActive(true);
                    Language(options2);
                    checkLanguage(options2);
                    break;
                }
            case "Sailor":
                {
                    break;
                }
            case "Soldier":
                {
                    break;
                }
            case "Urchin":
                {
                    break;
                }
        }
    }
    void setButtonsOn(string[] lists)
    {
        for (int i = 0; i < lists.Length; i++)
        {
            choices[i].gameObject.active = true;
            choices[i].interactable = true;
            choices[i].GetComponentInChildren<Text>().text = lists[i];
            countlines(lists[i]);
            choices[i].GetComponent<RectTransform>().sizeDelta = new Vector2(choices[i].GetComponent<RectTransform>().rect.width, h);
            
             if (selction[number] == choices[i].GetComponentInChildren<Text>().text)
             {
                choices[i].interactable = false;
             }
        }
    }
    public void getOption(int num)
    {
        choices[num].interactable = false;
        selction[number] = choices[num].GetComponentInChildren<Text>().text;
        for (int i = 0; i < choices.Length; i++)
        {
            if (i!=num){
            choices[i].interactable = true;
            }


        }
        Debug.Log(selction[number]);
    }
    void Language(Dropdown A)
    {
        A.options.Add(new Dropdown.OptionData() { text = "Common" });
        A.options.Add(new Dropdown.OptionData() { text = "Dwarvish" });
        A.options.Add(new Dropdown.OptionData() { text = "Elvish" });
        A.options.Add(new Dropdown.OptionData() { text = "Giant" });
        A.options.Add(new Dropdown.OptionData() { text = "Gnomish" });
        A.options.Add(new Dropdown.OptionData() { text = "Goblin" });
        A.options.Add(new Dropdown.OptionData() { text = "Halfing" });
        A.options.Add(new Dropdown.OptionData() { text = "Orc" });
        A.options.Add(new Dropdown.OptionData() { text = "Abyssal" });
        A.options.Add(new Dropdown.OptionData() { text = "Celestial" });
        A.options.Add(new Dropdown.OptionData() { text = "Draconic" });
        A.options.Add(new Dropdown.OptionData() { text = "Deep Speech" });
        A.options.Add(new Dropdown.OptionData() { text = "Infernal" });
        A.options.Add(new Dropdown.OptionData() { text = "Primordial" });
        A.options.Add(new Dropdown.OptionData() { text = "Sylvan" });
        A.options.Add(new Dropdown.OptionData() { text = "Undercommon" });
    }
    void checkLanguage(Dropdown A)
    {
        Debug.Log(A.name);
        for (int i = 0; i < 16; i++)
        {
            for (int q=1; q < A.options.Count;q++)
            {
                if (A.options[q].text == si.getlanuagelist(i))
                {
                    A.options.RemoveAt(q);
                }
            }
        }
    }
}
