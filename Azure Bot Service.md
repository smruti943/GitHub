# Create a Bot with the Bot Framework Composer
# Smruti Sanjeeta Jena

In this lab we will learn about QnA Maker and Azure Bot service.As we are designing chatbot which will act as afirst level of support
for users,it should act as human being.Means the way humans interacts with each other in a conversation. A typicall conversation is the exchange questions follwed by an answer.
In simlar way we have to train our bot to understand questions from Users and serve them with appropriate answers. With Azure QnA maker we will be able to create a knowledge base for our service.

# QnA Maker
QnA Maker service enables to define and publish a knowledge base of questions and answers with support for natural language querying. We define questions and answer for our services. Defining as many questions and answers makes the bot understand better.Once all defined,we have to train the bot and test the knowledge base.After training, one can use the built-in test interface in the QnA Maker portal to test bot's knowledge base by submitting questions and reviewing the answers that are returned.Once we are sure about the training of bot we can publish the knowledge base over its REST interface.

UseCase :
1. Chatbot should will start with a "May I help you" message.
2. Chatbot should first respond to user with Greetings
3. Chatbot should be able to give user different options to choose

Pricing:

Free -   3 managed docuemts per month,3 tansacations per second,100 transactions per minute

Standard - 10$ per month for unlimited managed documents,3 tansacations per second,100 transactions per minute 

# Create a bot
With Azure bot servie we will be able to create a bot and later integrate it to QnA maker. We have to create a resource called "Machine Learning" in azure.
Once "Machine Learning" resource created,we create a compute instance for notebook.After creating the bot its possible to connect it to multiple channels; making it possible for 
users to interact with it through web chat, email, Microsoft Teams, and other common communication media.


# Create a Bot with the Bot Framework Composer
Bot Framework Composer is a visual designer that helps you build sophisticated conversational bots without writing code. This is an open-source tool that presents a visual 
canvas for building bots.
In this module, we will learn how to:

create a basic bot with the composer
work with dialogs
use various cards within your bot
integrate LUIS


