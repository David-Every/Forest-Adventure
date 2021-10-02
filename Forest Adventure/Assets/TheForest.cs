using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TheForest : MonoBehaviour {

		public Text text;
		
		private enum States {
		club_0, club_1, club_2, toilet_0, toilet_1, ladies, mens, bar, water_0, seat_0,
		seat_1, friends, friends_1, friends_2, drink_0, party, outs, naked, forest, end
		};
		private States myState;
		
	// Use this for initialization
	void Start () {
			myState = States.club_0;
	}
	
	// Update is called once per frame
	void Update (){
		print (myState);
		if  	(myState == States.club_0)		{club_0();}
		else if (myState == States.club_1)		{club_1();}
		else if (myState == States.club_2)		{club_2();}
		else if (myState == States.toilet_0)	{toilet_0();}
		else if (myState == States.toilet_1)	{toilet_1();}
		else if (myState == States.ladies)		{ladies();}
		else if (myState == States.mens)		{mens();}
		else if (myState == States.bar)			{bar();}
		else if (myState == States.water_0)		{water_0();}
		else if (myState == States.friends)		{friends();}
		else if (myState == States.friends_1)	{friends_1();}
		else if (myState == States.friends_2)	{friends_2();}
		else if (myState == States.seat_0)		{seat_0();}
		else if (myState == States.seat_1)		{seat_1();}
		else if (myState == States.drink_0)		{drink_0();}
		else if (myState == States.party)		{party();}
		else if (myState == States.outs)		{outs();}
		else if (myState == States.naked)		{naked();}
		else if (myState == States.forest)		{forest();}
		else if (myState == States.end)			{end();}
	}
	#region State handler methods Level:Club
	void club_0(){
		text.text = "You are in a nightclub celebrating your friends 23rd Birthday " +
					"normally you are not the type to go out and drink as you are the " +
					"type to stay at home all night and play video games or watch television, " +
					"but tonight is a special occasion.\n\n\n\n\n"+
					"Press Space to continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.club_1;}
	}
	void club_1(){
		text.text = "As you and your friend James start drinking your third drink of the evening " +
					"you start to feel dizzy as the room starts slowly spinning. " +
					"Maybe its the alcohol?\n\n\n\n\n" +
					"Press 1. 'I'll be back in a second James just going to go to the toilet'\n"+
					"Press 2. 'Jeez i'm a lightweight i think im going to puke'";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.toilet_0;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.club_2;}
	}
	void club_2(){
		text.text = "James: ha,ha maybe you should get a glass of water from the bar?\n" +
					"Might make you feel better?\n\n\n\n"+
					"Press 1. Agree with James and go get some water\n" +
					"Press 2. Go to the Toilets\n" +
					"Press 3. Stay in your seat";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.bar;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.toilet_1;}
		else if (Input.GetKeyDown(KeyCode.Alpha3))		{myState = States.seat_0;}
	}
	void bar(){
		text.text = "You walk to the bar and the Barmaid asks you what you would like\n\n\n\n\n\n" +
					"Press 1. 'Water please.. i  think im getting a headache'";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.water_0;}
	}
	void seat_0(){
		text.text = "You decide to stay in your seat\n\n\n\n\n" +
					"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.seat_1;}
	}
	void seat_1(){
		text.text = "James: 'I thought you said you were feeling Dizzy?'\n\n\n\n\n\n" +
					"Press 1. its probably just the alcohol, i havnt had any in a while\n" +
					"Press 2. yeah im now going";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.friends;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.toilet_1;}
					
	}
	
	void water_0(){
		text.text = "The barmaid hands you a glass of water and you hand over the money for it.\n" +
			"you drink the Whole glass of water and start to feel better\n\n\n\n\n\n" +
				"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.friends;}
	}
	void toilet_0(){
		text.text = "James: Sure i'll call Mike and see where everyone else is.\n\n\n\n\n" +
					"Press Space to Continue";
		
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.toilet_1;}
	}
	void toilet_1(){
		text.text = "You get up out of your chair and follow the signs to the toilets\n\n\n\n\n\n\n" +
						"Press 1. to go in the Ladies toilets.\n" +
						"Press 2. to go in the Men's toilets.";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.ladies;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.mens;}		
	}
	void ladies(){
		text.text = "You go to walk into the Ladies Toilets but notice a sign on the door saying\n" +
					"'Out of Order, use the Mens'\n\n\n\n" +
					"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.mens;}
	}
	void mens(){
		text.text = "As you walk through the door of the mens toilets your dizzyness starts to get worse " +
					"you go into a stall and sit down, holding your head for a few minutes in the silence " +
					"until the dizzyness stops. You stand up and feel much better then when you entered " +
					"while you were in here you might as well use the toilet. Upon finishing you leave " +
					"the mens toilets and walk over to where James is sitting.\n\n\n" +
					"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.friends;}
	}
	void friends(){
		text.text = "After a while your friends all turn up in one group\n\n\n\n\n\n\n\n" +
					"Press 1.'What took you so long?'\n"+
					"Press 2.'Partys started now!'";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.friends_1;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.friends_2;}
	}
	void friends_1(){
		text.text = "Mike:'Well Max wasnt aloud in as he thought he would be funny and wear a mankini " +
					"but he has gone home to change now, shouldnt be too long haha.'\n" +
					"Hannah: Me and Jess just brought back some shots lets start the party!\n\n\n\n" +
					"Press 1.Take a shot and drink it\n" + 
					"Press 2.'I probably shouldnt i wasnt feeling too good earlier'";
		if 		(Input.GetKeyDown(KeyCode.Alpha1))		{myState = States.drink_0;}
		else if (Input.GetKeyDown(KeyCode.Alpha2))		{myState = States.friends_2;}
	}
	void friends_2(){
		text.text = "Jess:'Oh come on! Dont be such a party pooper and drink!'\n\n\n\n\n\n\n" +
					"Press D to Drink";
		if 		(Input.GetKeyDown(KeyCode.D))			{myState = States.drink_0;}
	}
	void drink_0(){
		text.text = "You drink the shot and start feeling alot better\n\n\n\n\n\n" +
					"Press Space to Continue";
			
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.party;}	
	}
	void party(){
		text.text = "A few hours have passed and you and all of your friends have had a few more then\n" +
					"a few to many drinks and have now left the club. some of your friends who turned up to the club " +
					"an hour late are walking infront of you fighting over a plastic box which they say is their " +
					"war helmet. You start feeling the dizzyness take over again. You blackout and collapse\n\n\n" +
					"Press Space to Continue";
		if  	(Input.GetKeyDown(KeyCode.Space))		{myState = States.outs;}
	}
	void outs(){
	text.text = "You start regaining consciousness, at first you cant move or rather dont want to move, your head is pounding " +
				"your eyes start to open but you cant make out much, everything is blurry."+
				"There is a noise in the background. like the sound of someone screaming " +
				"You struggle to keep your eyes open and eventually pass out\n\n\n" +
				"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.naked;}
	}
	void naked(){
		text.text = "You wake up and have a look around, You appear to be in a wooden shack, " +
					"confused you look more around the room and find a door which obviously leads outside" +
					"you also find a blanket on the floor which you realised you were sleeping on " +
					"now really worried you discover that not only are you in a shack and have no idea " +
					"where you are, but you are also Naked.\n\n" +
					"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.forest;}
	}
	void forest(){
		text.text = "moving towards the door you reach out and push the door open" +
					"on the door is a peice of paper that simply has the words" +
					"'Welcome to The Forest'\n\n\n\n" +
					"Press Space to Continue";
		if 		(Input.GetKeyDown(KeyCode.Space))		{myState = States.end;}
	}
	void end(){
		text.text = "The end... for now\n\n\n\n\n" +
					"Press P to Play again";
		if 		(Input.GetKeyDown(KeyCode.P))		{myState = States.club_0;}
	}
	#endregion
}
