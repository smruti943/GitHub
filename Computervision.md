# Laboratorium Computer Vision in Microsoft Azure Report

# Computer Vision API:

Computer vision is one of the azure cognitive vision services . This API designed to identify faces and expressions. It is also called as Face API. 
The Face API provides algorithm ,exposed as REST webservice calls to detect , verify , identify and analyse faces. Face API is designed to handle  below tasks:

1.	Verification : Check the likelihood that two faces belong to the same person.
2.	Detection : Detect human faces in an image.
3.	Identification : Search and identify faces.
4.	Similarity : Find similar faces.
5.	Grouping : Organize unidentified faces into groups, based on their visual similarity.

There are three different types of facial data which helps Face API to detect face in images.
Locations: In the image that includes a face, the Face API finds the top, left, width, and height coordinates of the face region. 
It is rectangular pixel area in the image where a face has been identified.
Landmarks: The Face API finds the position of common face elements, such as pupils, nose, and lips. It can return up to 27 landmarks for each identified face, 
that can be used for analysis.
Attributes: The Face API estimates face attributes such as age, gender, hair colour, smile, facial hair, glasses, and emotion.

Face API detects the image and provides data for Face recognition API. Face recognition API  builds recognition patterns from Face detect API. It helps to identify if the same face present in different images .
Storage capacity of Face API:
                            Face list: Up to 1,000 distinct faces
                            Person group: Up to 10,000 persons
                            Person: Up to 248 faces 


Text from Once we recognise face with Face detection API , then comes emotion detection. The Cognitive Services Emotion API builds on these results by using additional methods and algorithms to detect a rich set of emotions in images of human faces. Human face can have various emotions like anger, contempt, disgust, fear, happiness, neutral (the absence of emotion), sadness, and surprise.

Emotion API find these emotions with two parameters namely ,Score and Location.
Score: The likelihood or level of confidence that a face displays a specific emotion
Location: The top, left, height, and width of a region in the image that displays a face
Computer vision service  also able to identify an image or painting .

#Use Case:

1.	It should be possible to Identify faces in an image.
2.	System should be able to identify the different type of emotions in a face image like happy, anger , sad etc.
3.	It should be able to identify similar faces.
4.	System should be able to read text from an image.
Face API subscription need to be created before using the service. The subscription created in Azure portal with a resource.
There are two pricing tiers :
1.	Free with 20 calls per minute and 30K calls per month
2.	Standard 10 calls per second. Estimated at 0.84 EUR / 1000 calls


