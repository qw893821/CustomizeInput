# CustomizeInput
This is a research of change the input during the game. As Unity do not have the magic to change the input during when the game is running. Player will have the chance when they run the launcher but not in the game. 

To this, I build my own input first. To make this project easy. I simply change the coordinate with by using my customized input. No additional physical like mass or gravity like the input Unity have. 

First, I create a List with 4 element which store my default input for four directions. Instead of if the key is “horizontal” or “vertical” customized input need to check if the input is in the list I have created. If the key is in the list, then make reaction.

So far, I have the input now. The next step is to make it changeable. I use the button UI to trigger the function which allows me to change the input. To make the sure the input is on the keyboard, I use Event.current.is to check if the input is a keyboard event. When it is, them check the input. But, there is a change player have several key pressed at the same time, the “string” value which set to the input string will be longer than one letter. To avoid this, check the length of the string and remove all other than the first letter and the add first letter into the input list.

Now, the input is able to customize when game is running. When is key is set, the old input must be removed from the list to avoid confusion. 
