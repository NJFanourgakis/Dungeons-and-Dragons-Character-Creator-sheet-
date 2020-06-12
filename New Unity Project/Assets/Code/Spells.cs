using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string spells(string name)
    {
        // I have the duable switch to reduce the suecher time the firt switch just looking for the first letter and the second one looks for the full spell name 
        string d="";
        switch (name.Substring(0, 1))
        {
            case "A":
                {
                    switch (name)
                    {
                        case "Acid Splash":
                            {
                                d = "Conjuration cantrip \n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: 60 feet\n" +
                                    "Components: V, S\n" +
                                    "Duration: InstantaneousYou hurl a bubble of acid.Choose one creature within range, or choose two creatures within range that are within 5 feet of each other.\n" +
                                    "A target must succeed on a Dexterity saving throw or take 1d6 acid damage.\n" +
                                    "This spell’s damage increases by 1d6 when you reach 5th level(2d6), 11th level(3d6), and 17th level(4d6).\n";
                                break;
                            }
                        case "Aid":
                            {
                                d = "2nd-level abjuration\n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: 30 feet\n" +
                                    "Components: V, S, M(a tiny strip of white cloth)\n" +
                                    "Duration: 8 hours\n" +
                                    "Your spell bolsters your allies with toughness and resolve. Choose up to three creatures within range.\n" +
                                    "Each target's hit point maximum and current hit points increase by 5 for the duration.\n" +
                                    "At Higher Levels.When you cast this spell using a spell slot of 3rd level or higher,\n" +
                                    " a target's hit points increase by an additional 5 for each slot level above 2nd.\n";
                                break;
                            }
                        case "Alarm":
                            {
                                d = "1st‐level abjuration (ritual)\n" +
                                    "Casting Time: 1 minute\n" +
                                    "Range: 30 feet\n" +
                                    "Components: V, S, M(a tiny bell and a piece of fine silver wire)\n" +
                                    "Duration: 8 hours\n" +
                                    "You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20 - foot cube.\n" +
                                    "Until the spell ends, an alarm alerts you whenever a Tiny or larger creature touches or enters the warded area.When you cast the spell,\n" +
                                    "you can designate creatures that won't set off the alarm. You also choose whether the alarm is mental or audible.\n" +
                                    "A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area.This ping awakens you if you are sleeping.\n" +
                                    "An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.\n";
                                break;
                            }
                        case "Alter Self":
                            {
                                d = "2nd-level transmutation\n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: Self\n" +
                                    "Components: V, S\n" +
                                    "Duration: Concentration, up to 1 hour\n" +
                                    "You assume a different form. When you cast the spell, choose one of the following options, the effects of which last for the duration of the spell.\n" +
                                    "While the spell lasts, you can end one option as an action to gain the benefits of a different one.\n" +
                                    "Aquatic Adaptation. You adapt your body to an aquatic environment, sprouting gills and growing webbing between your fingers.\n" +
                                    "You can breathe underwater and gain a swimming speed equal to your walking speed.\n" +
                                    "Change Appearance. You transform your appearance. You decide what you look like, including your height, weight, facial features, sound of your voice,\n" +
                                    "hair length, coloration, and distinguishing characteristics, if any. You can make yourself appear as a member of another race, though none of your statistics change. \n" +
                                    "You also can't appear as a creature of a different size than you, and your basic shape stays the same; if you're bipedal, you can't use this spell to become quadrupedal, for instance.\n" +
                                    "At any time for the duration of the spell, you can use your action to change your appearance in this way again.\n" +
                                    "Natural Weapons. You grow claws, fangs, spines, horns, or a different natural weapon of your choice.\n" +
                                    "Your unarmed strikes deal 1d6 bludgeoning, piercing, or slashing damage, as appropriate to the natural weapon you chose, and you are proficient with your unarmed strikes.\n" +
                                    "Finally, the natural weapon is magic and you have a +1 bonus to the attack and damage rolls you make using it.\n";
                                break;
                            }
                        case "Animal Friendship":
                            {
                                d = "1st - level enchantment\n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: 30 feet\n" +
                                    "Components: V, S, M(a morsel of food)\n" +
                                    "Duration: 24 hours\n" +
                                    "This spell lets you convince a beast that you mean it no harm. Choose a beast that you can see within range.It must see and hear you.\n" +
                                    "If the beast's Intelligence is 4 or higher, the spell fails. Otherwise, the beast must succeed on a Wisdom saving throw or be charmed by you for the spell's duration.\n" +
                                    "If you or one of your companions harms the target, the spells ends.\n" +
                                    "At Higher Levels.When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional beast t level above 1st.\n";
                                break;
                            }
                        case "Animal Messenger":
                            {
                                d = "2nd-level enchantment (ritual)\n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: 30 feet\n" +
                                    "Components: V, S, M(a morsel of food)\n" +
                                    "Duration: 24 hours\n" +
                                    "By means of this spell, you use an animal to deliver a message. Choose a Tiny beast you can see within range, such as a squirrel, a blue jay, or a bat.\n" +
                                    "You specify a location, which you must have visited, and a recipient who matches a general description, such as (a man or woman dressed in the uniform of the town guard) or \n" +
                                    "(a red-haired dwarf wearing a pointed hat). You also speak a message of up to twenty - five words.The target beast travels for the duration of the spell toward the specified location,\n" +
                                    "covering about 50 miles per 24 hours for a flying messenger, or 25 miles for other animals. When the messenger arrives, it delivers your message to the creature that you described,\n " +
                                    "replicating the sound of your voice.The messenger speaks only to a creature matching the description you gave. If the messenger doesn't reach its destination before the spell ends, \n" +
                                    "the message is lost, and the beast makes its way back to where you cast this spell.\n" +
                                    "At Higher Levels.If you cast this spell using a spell slot of 3nd level or higher, the duration of the spell increases by 48 hours for each slot level above 2nd.\n";
                                break;
                            }
                        case "Animal Shaper":
                            {
                                d = "8th-level transmutation\n" +
                                    "Casting Time : 1 action\n" +
                                    "Components: V,S\n" +
                                    "Duration: Concentration, up to 24 hours\n" +
                                    "Your magic truns other int beasts. Choose any number of willing creatures that you can see within range. Yur transforn each target into the form of a large or smaller beast with a challenge\n" +
                                    "rating of 4 or lower. On subsequent turns, your can use your action to transform affected creastures into new forms. The transformation lasts for the duration for each target, or until the target\n" +
                                    "drops to 0 hit points or dies. You can choose a different form for each target. A target's game statistics are replaced by the statistics of the chosen beast, though the target retains its alignment\n" +
                                    "and Intelligence,Wisdom, and Charisma scores. The target assumes the hit point of its new form, and when it reverts to normal form,it returns to the number of hit points it had before it transformed.\n" +
                                    "If it reverts as a result of dropping to 0 hit points, any excess damage carries over to its normal form. As Long as the excess damage doesn't reduce the creatue's normal form to 0 hit points, it isn't\n" +
                                    "knocked unconscious. The creature is limited in the actions it can perform by the nature of its new form, and it can't speak or cast spells. The target's gear melds into the new form.\n" +
                                    "The target can't activate,wield, or otherwise benefit from any of its equipment.";
                                break;
                            }
                        case "Animate Dead":
                            {
                                d = "3rd-IeveI necromancy \n" +
                                    "Casting Time: 1 minute \n" +
                                    "Range: 10 feet\n" +
                                    "Components: V, S, M (a drop of blood, a piece of flesh, and a pinch of bone dust) \n" +
                                    "Duration: Instantaneous\n" +
                                    "This spell creates an undead servant. Choose a pile of bones or a corpse of a Medium or Small humanoid within range. Your spell imbues the target with a \n" +
                                    "foul mimicry of life, raising it as an undead creature. The target becomes a skeleton if you chose bones or a zombie if you chose a corpse (the GM has the creature’s game statistics).\n" +
                                    " On each of your turns, you can use a bonus action to mentally command any creature you made with this spell if the creature is within 60 feet of you \n " +
                                    "(if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). \n" +
                                    "You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor.\n " +
                                    "If you issue no commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete.\n" +
                                    " The creature is under your control for 24 hours, after which it stops obeying any command you’ve given it. To maintain control of the creature for another 24 hours, \n" +
                                    "you must cast this spell on the creature again before the current 24 - hour periodends.This use of the spell reasserts your control over up to four creatures you have animated with\n" +
                                    "this spell, rather than animating a new one. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you animate orreassert control over two additional undead\n" +
                                    "creatures for each slot level above 3rd.Each of the creatures must come from a different corpse or pileof bones.\n";
                                break;
                            }
                        case "Animate Objects":
                            {
                                d = "5th-IeveI transmutation\n" +
                                    "Casting Time: 1 action \n" +
                                    "Range: 120 feet\n" +
                                    "Components: V, S\n" +
                                    "Duration: Concentration, up to 1 minute\n" +
                                    "Objects come to life at your command. Choose up to ten nonmagical objects within range that are not being worn or carried.Medium targets count as two \n" +
                                    "objects, Large targets count as four objects, Huge targets count as eight objects.You can’t animate any object larger than Huge. Each target animates and \n" +
                                    "becomes a creature under your control until the spell ends or until reduced to 0 hit points. As a bonus action, you can mentally command any creature you made with this spell if the creature is\n" +
                                    "within 500 feet of you(if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). \n" +
                                    "You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor. If you issue no\n" +
                                    "commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete. Animated Object Statistics\n" +
                                    "Size   | HP | AC | Str | Dex | Attack |\n" +
                                    "Tiny   | 20 | 18 |  4  | 18  | + 8 to hit, ld4 +4 damage   |\n" +
                                    "Small  | 25 | 16 |  6  | 14  | + 6 to hit, ld8 +2 damage   |\n" +
                                    "Medium | 40 | 13 | 10  | 12  | + 5 to hit, 2d6 + 1 damage  |\n" +
                                    "Large  | 50 | 10 | 14  | 10  | + 6 to hit, 2dl0 + 2 damage |\n" +
                                    "Huge   | 80 | 10 | 18  |  6  | + 8 to hit, 2dl2 + 4 damage |\n" +
                                    "An animated object is a construct with AC, hit points, attacks, Strength, and Dexterity determined by its size. Its Constitution is 10 and its Intelligence and Wisdom are 3, and its Charisma is 1.Its speed is\n" +
                                    "30 feet; if the object lacks legs or other appendages it can use for locomotion, it instead has a flying speed of 30 feet and can hover.If the object is securely attached to a surface or a larger object, \n" +
                                    "such as a chain bolted to a wall, its speed is 0.It has blindsight with a radius of 30 feet and is blind beyond that distance.When the animated object drops to 0 hit points, \n" +
                                    "it reverts to its original object form, and any remaining damage carries over to its original objectform.\n" +
                                    "If you command an object to attack, it can make a single melee attack against a creature within 5 feet of it.It makes a slam attack with an attack bonus and bludgeoning damage determined by its size.The GM\n" +
                                    "might rule that a specific object inflicts slashing or piercing damage based on its form.\n" +
                                    "At Higher Levels.If you cast this spell using a spell slot of 6th level or higher, you can animate two additional objects for each slot level above 5th. ";
                                break;
                            }
                        case "Antilfe Shell":
                            {
                                d = "5th-IeveI abjuration\n " +
                                    "Casting Time: 1 action\n" +
                                    "Range: Self(10 - foot radius)\n" +
                                    "Components: V, S\n" +
                                    "Duration: Concentration, up to 1 hour\n" +
                                    "A shimmering barrier extends out from you in a 10 - foot radius and moves with you, remaining centered on you and hedging out creatures other than undead and constructs. The barrier lasts for the duration.\n " +
                                    "The barrier prevents an affected creature from passing or reaching through.An affected creature can cast spells or make attacks with ranged or reach weapons through the barrier.\n" +
                                    "If you move so that an affected creature is forced to pass through the barrier, the spell ends. ";
                                break;
                            }
                        case "Antimagic Field":
                            {
                                d = "8th-IeveI abjuration\n " +
                                    "Casting Time: 1 action\n" +
                                    "Range: Self(10 - foot - radius sphere)\n" +
                                    "Components: V, S, M(a pinch of powdered iron or iron filings)\n" +
                                    "Duration: Concentration, up to 1 hour\n" +
                                    "10 - foot - radius invisible sphere of antimagic surrounds you. This area is divorced from the magical energy that suffuses the multiverse.Within the sphere, spells can’t be cast, summoned creatures\n" +
                                    "disappear, and even magic items become mundane. Until the spell ends, the sphere moves with you, centered on you. Spells and other magical effects, except those created by an artifact or a deity, are suppressed in\n " +
                                    "the sphere and can’t protrude into it. A slot expended to cast a suppressed spell is consumed. While an effect is suppressed, it doesn’t function, but the time it spends suppressed counts against its duration.\n" +
                                    "Targeted Effects. Spells and other magical effects, such as magic missile and charm person, that target a creature or an object in the sphere have no effect on that target. \n" +
                                    "Areas of Magic.The area of another spell or magical effect, such as fireball, can’t extend into the sphere.If the sphere overlaps an area of magic,\n" +
                                    " the part of the area that is covered by the sphere is suppressed.For example, the flames created by a wall of fire are suppressed within the sphere, creating a gap in the wall if the overlap is large enough.\n" +
                                    "Spells.Any active spell or other magical effect on a creature or an object in the sphere is suppressed while the creature or object is in it.\n" +
                                    "Magic Items. The properties and powers of magic items are suppressed in the sphere. For example, a +1 longsword in the sphere functions as a nonmagical longsword. \n" +
                                    "A magic weapon’s properties and powers are suppressed if it is used against a target in the sphere or wielded by an attacker in the sphere. \n" +
                                    "If a magic weapon or a piece of magic ammunition fully leaves the sphere(for example, if you fire a magic arrow or throw a magic spear at a target outside the sphere), " +
                                    "the magic of the item ceases to be suppressed as soon as it exits.\n" +
                                    "Magical Travel. Teleportation and planar travel fail to work in the sphere, whether the sphere is the destination or the departure point for such magical travel.\n" +
                                    "A portal to another location, world, or plane of existence, as well as an opening to an extradimensional space such as that created by the rope trick spell, temporarily closes while in the sphere.\n" +
                                    "Creatures and Objects.A creature or object summoned or created by magic temporarily winks  out of existence in the sphere. \n" +
                                    "Such a creature instantly reappears once the space the creature occupied is no longer within the sphere.\n" +
                                    "Dispel Magic. Spells and magical effects such as dispel magic have no effect on the sphere.Likewise, the spheres created by different antimagic fieldspells don’t nullify each other.";
                                break;
                            }
                        case "Antipathy/Sympathy":
                            {
                                d = "8th-IeveI enchantment\n " +
                                    "Casting Time: 1 hour\n" +
                                    "Range: 60 feet\n" +
                                    "Components: V, S, M(either a lump of alum soaked\n" +
                                    "in vinegar for the antipathy effect or a drop of honey for the sympathy effect)\n" +
                                    "Duration: 10 days\n" +
                                    "This spell attracts or repels creatures of your choice. You target something within range, either a Huge or smaller object or creature or an area that is no larger than a 200 - foot cube.\n" +
                                    "Then specify a kind of intelligent creature, such as red dragons, goblins, or vampires.You invest the target with an aura that either attracts or repels the specified creatures for the duration.\n" +
                                    " Choose antipathy or sympathy as the aura’s effect. Antipathy.The enchantment causes creatures of the kind you designated to feel an intense urge to leave the area and avoid the target.\n" +
                                    "When such a creature can see the target or comes within 60 feet of it, the creature must succeed on a Wisdom saving throw or become frightened.\n" +
                                    "The creature remains frightened while it can see the target or is within 60feet of it.While frightened by the target, the creature must use its movement to move to the nearest safe spot from which it can’t see the target.\n " +
                                    "If the creaturemoves more than 60 feet from the target and can’t see it, the creature is no longer frightened, but the creature becomes frightened again if it regains sight of the target or moves within 60 feet of it. \n" +
                                    "Sympathy.The enchantment causes the specified creatures to feel an intense urge to approach the target while within 60 feet of it or able to see it.\n " +
                                    "When such a creature can see the target or comes within 60 feet of it, the creature must succeed on a Wisdom saving throw or use its movement on each of its turns to enter the area or move within reach of the target.\n" +
                                    "When the creature has done so, it can’t willingly move away from the target. If the target damages or otherwise harms an affected creature, the affected creature can make a Wisdom saving throw to end the effect, as described below.\n" +
                                    "Ending the Effect.If an affected creature ends its turn while not within 60 feet of the target or able to see it, the creature makes a Wisdom saving throw.\n" +
                                    " On a successful save, the creature is no longeraffected by the target and recognizes the feeling of repugnance or attraction as magical.\n" +
                                    "In addition, a creature affected by the spell is allowed another Wisdom saving throw every 24 hours while the spell persists.\n" +
                                    "A creature that successfully saves against this effect is immune to it for 1 minute, after which time it can be affected again.";
                                break;
                            }
                        case "Arcane Eye":
                            {
                                d = "4th-level divination\n " +
                                    "Casting Time: 1 action\n" +
                                    "Range: 30 feet\n" +
                                    "Components: V, S, M(a bit of bat fur)\n" +
                                    "Duration: Concentration, up to 1 hour\n" +
                                    "You create an invisible, magical eye within range that hovers in the air for the duration. You mentally receive visual information from the eye, which has normal vision and darkvision out to 30 feet.\n" +
                                    "The eye can look in every direction. As an action, you can move the eye up to 30 feet in  any direction.There is no limit to how far away from you the eye can move, but it can’t enter another plane of existence.\n" +
                                    "A solid barrier blocks the eye’s movement, but the eye can pass through an opening as small as 1 inch in diameter. ";
                                break;
                            }
                        case "Arcane Gate":
                            {
                                d = "";
                                break;
                            }
                        case "Arcane Lock":
                            {
                                d = "2nd-level abjuration \n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: Touch\n" +
                                    "Components: V, S, M(gold dust worth at least 25 gp, which the spell consumes)\n" +
                                    "Duration: Until dispelled\n" +
                                    "You touch a closed door, window, gate, chest, or other entryway, and it becomes locked for the duration.You and the creatures you designate when you cast this spell can open the object normally.\n" +
                                    "You can also set a password that, when spoken within 5 feet of the object, suppresses this spell for 1 minute. Otherwise, it is impassable until it is broken or the spell is dispelled or suppressed.\n" +
                                    "Casting knock on the object suppresses arcane lock for 10 minutes. While affected by this spell, the object is more difficult to break or force open; the DC to break it or pick any locks on it increases by 10.";
                                break;
                            }
                        case "Armor of Agathys":
                            {
                                break;
                            }
                        case "Arms of Handar":
                            {
                                break;
                            }
                        case "Astral Projectoin":
                            {
                                d = "9th-level necromancy\n" +
                                    "Casting Time: 1 hour\n" +
                                    "Range: 10 feet\n" +
                                    "Components: V, S, M(for each creature you affect with this spell, you must provide one jacinth worth at least 1, 000 gp and one ornately carved bar of silver worth at least 100 gp, all of which the spell consumes)\n" +
                                    "Duration: Special \n" +
                                    "You and up to eight willing creatures within range project your astral bodies into the Astral Plane(the spell fails and the casting is wasted if you are already on that plane).\n " +
                                    "The material body you leave behind is unconscious and in a state of suspended animation; it doesn’t need food or air and doesn’t age. \n" +
                                    "Your astral body resembles your mortal form in  almost every way, replicating your game statistics and possessions.\n " +
                                    "The principal difference is the addition of a silvery cord that extends from between your shoulder blades and trails behind you, fading to invisibility after 1 foot.\n" +
                                    "This cord is your tether to your material body. As long as the tether remains intact, you can find your way home.\n" +
                                    " If the cord is cut — something that can happen only when an effect specifically states that it does — your soul and body are separated, killing you instantly.\n" +
                                    " Your astral form can freely travel through the Astral Plane and can pass through portals there leading to any other plane.If you enter a new plane or return to the plane you were on when casting this spell,\n" +
                                    "w your body and possessions are transported along the silver cord, allowing you to re - enter your body as you enter the new plane.Your astral form is a separate incarnation.\n" +
                                    "Any damage or other effects that apply to it have no effect on your physical body, nor do they persist when you return to it. The spell ends for you and your companions when you use your action to dismiss it.\n" +
                                    "When the spell ends, the affected creature returns to its physical body, and it awakens. The spell might also end early for you or one of your companions.\n" +
                                    "A successful dispel magic spell used against an astral or physical body ends the spell for that creature. If a creature’s original body or its astral form drops to 0 hit points, the spell ends for that creature.\n " +
                                    "If the spell ends and the silver cord isvintact, the cord pulls the creature’s astral form back to its body, ending its state of suspended animation.If you are returned to your body prematurely,\n" +
                                    " your companions remain in their astral forms and must find their own way back to their bodies, usually by dropping to 0 hit points. ";
                                break;
                            }
                        case "Augury":
                            {
                                d = "2nd-level divination (ritual) \n" +
                                    "Casting Time: 1 minute\n" +
                                    "Range: Self\n" +
                                    "Components: V, S, M(specially marked sticks, bones, or similar tokens worth at least 25 gp)\n" +
                                    "Duration: Instantaneous\n" +
                                    "By casting gem-inlaid sticks, rolling dragon bones,  laying out ornate cards, or employing some other divining tool,\n " +
                                    "you receive an omen from an otherworldly entity about the results of a specific course of action that you plan to take within the next 30 minutes.The GM chooses from the following \n" +
                                    "possible omens: \n" +
                                    "• Weal, for good results \n" +
                                    "• Woe, for bad results \n" +
                                    "• Weal and woe, for both good and bad results \n" +
                                    "• Nothing, for results that aren’t especially good or bad\n" +
                                    "The spell doesn’t take into account any possible circumstances that might change the outcome, such as the casting of additional spells or the loss or gain of a companion.\n " +
                                    "If you cast the spell two or more times before completing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get a random reading.The GM makes this roll in  secret. ";
                                break;
                            }
                        case "Aura of Life":
                            {
                                d = "4th-level abjuration\n" +
                                    "Casting Time: 1 action\n" +
                                    "Rage: Self (30-foot radius)\n" +
                                    "components: V\n" +
                                    "Duration: Concentration, up to 10 minutes\n" +
                                    "Life-preserving energy radiates from you in an aura with a 30-foot radius. Unitl the spell ends, the aura moves with you, centered on you. Each nonhostile creature\n" +
                                    "in the aura (including you) has resistance to necrotic damage, and its hit point maximum can't be reduced. In addition, a nonhostile, live creature regains 1 hit point when it starts its turn in the aura with 0 nit point\n";
                                break;
                            }
                        case "Aura of Purity":
                            {
                                d = "4th-level abjuration\n" +
                                    "Range: Self (30-foot radius)\n" +
                                    "Components: V\n" +
                                    "Duration: Concentration, up to 10 minutes\n" +
                                    "Purifying energy radiates from you in an aura with a 30-foot radius. Until the spell ends, the aura moves with you, centered on you.\n" +
                                    "Each nonhostile creature in the aure (including you) can't become diseased, has resistance to poison damage and has advantage on saving throws\n" +
                                    "against effect that cause any of the following conditions: blinded, charmed, deafened, frightened, paralyzed, poisoned and stunned.\n";
                                break;
                            }
                        case "Aura of Vitality":
                            {
                                d = "3rd-level evocation\n" +
                                    "Casting Time: 1 action\n" +
                                    "Range: Self (30-foot radius)\n" +
                                    "Components: V\n" +
                                    "Duration: Concentration, up to 1 minutes\n" +
                                    "Healing energy radiates from you in an aura with a 30-foot radius. Until the spell ends, the aura moveswith you, sentered on you.\n" +
                                    "you can use a bous action to cause one creature in the aura(including you) to regain 2d6 hit points.\n";
                                break;
                            }
                        case "Awaken":
                            {
                                d = "5th-level transmutation \n" +
                                    "Casting Time: 8 hours\n" +
                                    "Range: Touch \n" +
                                    "Components: V, S, M(an agate worth at least 1, 000 gp, which the spell consumes)" +
                                    "Duration: Instantaneous\n" +
                                    "After spending the casting time tracing magical pathways within a precious gemstone, you touch a Huge or smaller beast or plant.The target must have either no Intelligence score or an Intelligence of 3 or less.\n" +
                                    "The target gains an Intelligence of 10. The target also gains the ability to speak one language you know. If the target is a plant, it gains the ability to move its limbs, roots, vines, creepers, and so forth, and it gains senses similar to a human’s.\n" +
                                    "Your GM chooses statistics appropriate for the awakened plant, such as the statistics for the awakened shrub or the awakened tree. The awakened beast or plant is charmed by you for 30 days or until you or your companions do anything harmful to it.\n" +
                                    "When the charmed condition ends, the awakened creature chooses whether to remain friendly to you, based on how you treated it while it was charmed. ";
                                break;
                            }
                    }
                    break;
                }
            case "B":
                {
                    break;
                }
            case "C":
                {
                    break;
                }
            case "D":
                {
                    break;
                }
            case "E":
                {
                    break;
                }
            case "F":
                {
                    break;
                }
            case "G":
                {
                    break;
                }
            case "H":
                {
                    break;
                }
            case "I":
                {
                    break;
                }
            case "J":
                {
                    break;
                }
            case "K":
                {
                    break;
                }
            case "L":
                {
                    break;
                }
            case "M":
                {
                    break;
                }
            case "N":
                {
                    break;
                }
            case "O":
                {
                    break;
                }
            case "P":
                {
                    break;
                }
            case "Q":
                {
                    break;
                }
            case "R":
                {
                    break;
                }
            case "S":
                {
                    break;
                }
            case "T":
                {
                    break;
                }
            case "U":
                {
                    break;
                }
            case "V":
                {
                    break;
                }
            case "W":
                {
                    break;
                }
            case "Y":
                {
                    break;
                }
            case "X":
                {
                    break;
                }
            case "Z":
                {
                    break;
                }
        }
        return d;
    }
}
