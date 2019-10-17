# Xaya Name Utility

The Xaya Name Utility is a simple program to let you bulk register many names all at once and to bulk send Xaya names in your wallet to a CHI address.

# Running the program

The program is located here:

    \XayaNameUtility\bin\Release\XayaNameUtility.exe

Simply double click to run it. See "Wallet settings" below to get started.

# Wallet settings

NOTE: You must have xayad running to use this program. If you are running the Xaya Electron wallet or QT wallet, then xayad is running and you're good to go.

However, you must enter the RPC username and password for each wallet. This must be done each time that you restart the wallet as the password changes for every restart. (Automatically doing this was not considered important and not added to the program because it's unlikely that anyone will use this very much.)

By default, the program includes the proper settings, except for the RPC username and password, for the Game, Vault, and Default wallets.

In the wallet settings, click on each of those in turn and then click the autofill button. It will read the proper RPC username and password from your Xaya .cookie file. Click the Add button to add that wallet setting. Remove the entries with no username or password then save the settings and close the Settings window. 

You can then use the wallet drop down menu to change between wallets. You will see in the program title bar that the name of the selected wallet and its CHI balance will be displayed. 

# Bulk registering names

Manually registering names can be very tedious if you have a long list of names that you want. The solution is to create a list and then register them all at once.

Names must include a Xaya namespace, e.g. "p/" for Xaya player account names or "g/" for game names for developers. Here's a simple example:

    p/first name in list
    p/second name in list
    ...
    p/nth name in list

You can copy and paste your list into the program then register them all at once. 

# Bulk sending names

Managing many names in a single wallet can be difficult for various reasons. Games may have drop down menus for names that are small or difficult to use with many names.

It may be helpful to store names in your Vault wallet or a special wallet specifically for names.

However, manually sending each individual name when you have 10s or 100s of names is difficult and tedious. 

The obvious solution is to send many names all at once.

Click the button to populate the list with all the names in your wallet. Next, check the boxes for names you'd like to send. Paste the CHI address that you want to send them to into the text box then click the Send button to send them all at once. 

# Support

There is no official support for this utility from the Xaya team. However you can still ask in the Xaya Discord support channel or in the Xaya forums. 
