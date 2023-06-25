Sub EthicalTechDesignAndDigitalWellnessWorkshops()
    Dim workshopTitle As String
    workshopTitle = "Ethical Tech Design and Digital Wellness Workshops"

    'Declare and set variables
    Dim workshopDescription As String
    workshopDescription = "This workshop will explore the fundamentals of ethical tech design and digital wellness, as well as the implications of the ethical use of technology for our lifestyles and communities."
    Dim workshopLocation As String
    workshopLocation = "Atlanta, GA"
    Dim contactEmail As String
    contactEmail = "info@tech-learning.org"
    Dim workshopDate As Date
    workshopDate = #9/12/2020#

    'Array variable to store workshop topics
    Dim workshopTopics(4) As String
    workshopTopics(0) = "What is ethical design?"
    workshopTopics(1) = "Understanding the implications of technology on our personal lives"
    workshopTopics(2) = "The effects of digital wellness on our families and communities"
    workshopTopics(3) = "Creating ethical designs and applications"
    workshopTopics(4) = "The role of technology in promoting digital wellness"

    'Output workshop information
    Debug.Print "Title: " & workshopTitle
    Debug.Print "Description: " & workshopDescription
    Debug.Print "Location: " & workshopLocation
    Debug.Print "Contact Email: " & contactEmail
    Debug.Print "Date: " & workshopDate
    Debug.Print "Workshop Topics: "

    'Loop through and output workshop topics
    Dim topic As String
    For Each topic In workshopTopics
        Debug.Print vbTab & topic
    Next topic

End Sub