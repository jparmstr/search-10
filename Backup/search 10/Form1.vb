Imports System.IO
Imports System.Threading
Imports System.ComponentModel
Imports System.Net

Public Class Form1

#Region "declarations"
    Public Shared path As String = System.AppDomain.CurrentDomain.BaseDirectory

    Shared WithEvents phase1Worker As New BackgroundWorker
    Shared phase1Stream As Phase
    Shared phase1Thread As Thread

    Shared WithEvents phase2Worker As New BackgroundWorker
    Shared phase2Stream As Phase
    Shared phase2Thread As Thread

    Shared WithEvents phase3Worker As New BackgroundWorker
    Shared phase3Stream As Phase
    Shared phase3Thread As Thread

    Shared WithEvents phase4Worker As New BackgroundWorker
    Shared phase4Stream As Phase
    Shared phase4Thread As Thread

    Shared WithEvents phase5Worker As New BackgroundWorker
    Shared phase5Stream As Phase
    Shared phase5Thread As Thread

    Shared WithEvents phase6Worker As New BackgroundWorker
    Shared phase6Stream As Phase
    Shared phase6Thread As Thread

    Shared WithEvents phase7Worker As New BackgroundWorker
    Shared phase7Stream As Phase
    Shared phase7Thread As Thread

    Shared WithEvents phase8Worker As New BackgroundWorker
    Shared phase8Stream As Phase
    Shared phase8Thread As Thread

    Shared WithEvents phase9Worker As New BackgroundWorker
    Shared phase9Stream As Phase
    Shared phase9Thread As Thread

    Shared WithEvents phase0Worker As New BackgroundWorker
    Shared phase0Stream As Phase
    Shared phase0Thread As Thread

    Dim WithEvents scheduleWorker As New BackgroundWorker
    Private scheduleStream As Scheduler
    Private scheduleThread As Thread

    Dim WithEvents searchWorker As New BackgroundWorker
    Private searchStream As searcher
    Private searchThread As Thread

    Public Shared linkList As New List(Of String)
    Public Shared linkListPosition As Integer = 0
    Public Shared domainList As New List(Of String)
    Public Shared domainListPosition As Integer = 0
    Public Shared masterDomain As String
    Public Shared masterDomainNoWWW As String

    Public Shared mainIndex_working As New List(Of wordMultiInfo)
    Public Shared mainIndex_InUse As Boolean = False
    Public Shared currentRefNumber As Integer = 0
    Public Shared refList As New List(Of String)

    'these are the files loaded from disk for the search process
    Public Shared loadedIndex As New List(Of wordMultiInfo)
    Public Shared loadedRefList As New List(Of String)

    Public Shared startTime As DateTime
    Public Shared endTime As DateTime
    Public Shared elapsedTime As TimeSpan

    Delegate Sub scbScanningHost(ByVal [name] As String)
    Delegate Sub scbHostPosition(ByVal [int] As Integer, ByVal [max] As Integer)
    Delegate Sub scbDomainListPosition(ByVal [int] As Integer, ByVal [max] As Integer)
    Delegate Sub scbEntriesInIndex(ByVal [int] As Integer)
    Delegate Sub scb1(ByVal [text] As String)
    Delegate Sub scb2(ByVal [text] As String)
    Delegate Sub scb3(ByVal [text] As String)
    Delegate Sub scb4(ByVal [text] As String)
    Delegate Sub scb5(ByVal [text] As String)
    Delegate Sub scb6(ByVal [text] As String)
    Delegate Sub scb7(ByVal [text] As String)
    Delegate Sub scb8(ByVal [text] As String)
    Delegate Sub scb9(ByVal [text] As String)
    Delegate Sub scb0(ByVal [text] As String)
    Delegate Sub scbSiteBar(ByVal [int] As Integer, ByVal [max] As Integer)
    Delegate Sub scbTSLastWordAdded(ByVal [text] As String)
#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        phase1Stream = New Phase(Me)
        phase2Stream = New Phase(Me)
        phase3Stream = New Phase(Me)
        phase4Stream = New Phase(Me)
        phase5Stream = New Phase(Me)
        phase6Stream = New Phase(Me)
        phase7Stream = New Phase(Me)
        phase8Stream = New Phase(Me)
        phase9Stream = New Phase(Me)
        phase0Stream = New Phase(Me)
        scheduleStream = New Scheduler(Me)
        searchStream = New searcher(Me)

        If Not Directory.Exists(path + "main\") Then
            My.Computer.FileSystem.CreateDirectory(path + "main\")
        End If
        If Not File.Exists(path + "main\~invIndex.txt") Then
            File.Create(path + "main\~invIndex.txt")
        End If
        If Not File.Exists(path + "main\~indexDomain.txt") Then
            File.Create(path + "main\~indexDomain.txt")
        End If
        If Not File.Exists(path + "main\~refList.txt") Then
            File.Create(path + "main\~refList.txt")
        End If

        'load previously scanned sites into combobox1
        Dim rootRAM As New DirectoryInfo(path + "main\")
        Dim fileListRAM As FileInfo() = rootRAM.GetFiles("*.txt")
        Dim fileNameRAM As FileInfo
        For Each fileNameRAM In fileListRAM
            If Not fileNameRAM.Name = "~indexDomain.txt" Then
                If Not fileNameRAM.Name = "~invIndex.txt" Then
                    If Not fileNameRAM.Name = "~refList.txt" Then
                        ComboBox1.Items.Add(httpCheck(Replace(fileNameRAM.Name, ".txt", "")))
                    End If
                End If
            End If
        Next

        'load inverted index and refList - resume indexing process
        mainIndex_working = loadInvertexIndexToListOfWordMultiInfo()
        loadRefList()
        currentRefNumber = refList.Count
        streamUpdateEntriesInIndex(mainIndex_working.Count)

    End Sub


    Shared Sub phase1Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase1Worker.DoWork
        phase1Thread = New Thread(New ThreadStart(AddressOf phase1Stream.scan))
        phase1Thread.Start()

        phase1Thread.Join()
    End Sub

    Shared Sub phase2Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase2Worker.DoWork
        phase2Thread = New Thread(New ThreadStart(AddressOf phase2Stream.scan))
        phase2Thread.Start()

        phase2Thread.Join()
    End Sub

    Shared Sub phase3Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase3Worker.DoWork
        phase3Thread = New Thread(New ThreadStart(AddressOf phase3Stream.scan))
        phase3Thread.Start()

        phase3Thread.Join()
    End Sub

    Shared Sub phase4Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase4Worker.DoWork
        phase4Thread = New Thread(New ThreadStart(AddressOf phase4Stream.scan))
        phase4Thread.Start()

        phase4Thread.Join()
    End Sub

    Shared Sub phase5Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase5Worker.DoWork
        phase5Thread = New Thread(New ThreadStart(AddressOf phase5Stream.scan))
        phase5Thread.Start()

        phase5Thread.Join()
    End Sub

    Shared Sub phase6Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase6Worker.DoWork
        phase6Thread = New Thread(New ThreadStart(AddressOf phase6Stream.scan))
        phase6Thread.Start()

        phase6Thread.Join()
    End Sub

    Shared Sub phase7Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase7Worker.DoWork
        phase7Thread = New Thread(New ThreadStart(AddressOf phase7Stream.scan))
        phase7Thread.Start()

        phase7Thread.Join()
    End Sub

    Shared Sub phase8Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase8Worker.DoWork
        phase8Thread = New Thread(New ThreadStart(AddressOf phase8Stream.scan))
        phase8Thread.Start()

        phase8Thread.Join()
    End Sub

    Shared Sub phase9Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase9Worker.DoWork
        phase9Thread = New Thread(New ThreadStart(AddressOf phase9Stream.scan))
        phase9Thread.Start()

        phase9Thread.Join()
    End Sub

    Shared Sub phase0Work(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles phase0Worker.DoWork
        phase0Thread = New Thread(New ThreadStart(AddressOf phase0Stream.scan))
        phase0Thread.Start()

        phase0Thread.Join()
    End Sub

    Private Sub scheduleWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles scheduleWorker.DoWork
        scheduleThread = New Thread(New ThreadStart(AddressOf scheduleStream.runThreads))
        scheduleThread.Start()

        scheduleThread.Join()
    End Sub

    Private Sub scheduleWorkDone(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles scheduleWorker.RunWorkerCompleted
        'advance to the next spot in the domainList
        If Not domainListPosition = domainList.Count - 1 Then
            writeOutSite()
            domainListPosition += 1
            writeOutDomainList()
            linkList.Clear()
            linkListPosition = 0
            writeOutRefList()
            writeOutInvertedIndexFromListOfWordMultiInfo()

            streamUpdateDomainListPosition(domainListPosition, domainList.Count)
            streamUpdateScanningHost(getDomainLocal(domainList(domainListPosition)))

            'resume a partially completed site (if domain name already exists)
            'this issue (www. variants) needs to be fixed by normalizing domain names before they are ever scanned
            Dim loaded As Boolean = False
            If File.Exists(path + "main\" + Replace(domainList(domainListPosition), "http://", "") + ".txt") Then
                loadLinkListFromFile(Replace(domainList(domainListPosition), "http://", ""))
                loaded = True
            End If
            If Not loaded Then
                If File.Exists(path + "main\www." + Replace(domainList(domainListPosition), "http://", "") + ".txt") Then
                    loadLinkListFromFile("www." + Replace(domainList(domainListPosition), "http://", ""))
                    loaded = True
                End If
            End If
            If Not loaded Then
                If File.Exists(path + "main\" + Replace(Replace(domainList(domainListPosition), "http://", ""), "www.", "") + ".txt") Then
                    loadLinkListFromFile(Replace(Replace(domainList(domainListPosition), "http://", ""), "www.", ""))
                End If
            Else
                'if there is nothing to resume, add the next domain the the linklist as a starting point
                linkList.Add(domainList(domainListPosition))
            End If
            scheduleWorker.RunWorkerAsync()
        Else
            MsgBox("Dead End??")
            ButtonStart.Enabled = True
            ButtonResume.Enabled = True
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub searchWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles searchWorker.DoWork
        searchThread = New Thread(New ThreadStart(AddressOf searchStream.findSingle))
        searchThread.Start()

        searchThread.Join()
    End Sub

    Private Sub searchWorkDone(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles searchWorker.RunWorkerCompleted
        'MsgBox("time to process query : " + elapsedTime.TotalSeconds.ToString("0.00"))

        openLink(path + "searchResults.html")
    End Sub


    Public Class Scheduler
        Private m_frm As Form1
        Private stopFlag As Boolean = False
        Public writeOutNextChance As Boolean = False

        Public Sub New(ByRef p_form As Form1)
            m_frm = p_form
        End Sub

        Public Sub runThreads()
            masterDomain = LCase(getDomain(linkList(linkListPosition)))
            masterDomainNoWWW = masterDomain.Replace("http://", "")
            masterDomainNoWWW = masterDomainNoWWW.Replace("www.", "")

            While Not stopFlag
                If Not linkList.Count = 1 Then
                    linkListPosition += 1
                End If
                currentRefNumber += 1
                refList.Add(CStr(currentRefNumber) + " " + linkList(linkListPosition))
                giveToNextAvailableThread(linkList(linkListPosition))

                m_frm.streamUpdateHostPosition(linkListPosition - 1, linkList.Count)
                m_frm.streamUpdateSiteProgress(linkListPosition - 1, linkList.Count)

                If writeOutNextChance Then
                    waitUntilAllThreadsAreDone()

                    writeOutDomainList()
                    writeOutRefList()
                    writeOutSite()
                    writeOutInvertedIndexFromListOfWordMultiInfo()

                    writeOutNextChance = False
                End If

                If linkListPosition + 1 >= linkList.Count - 1 Then
                    waitUntilAllThreadsAreDone()
                    'this should give it the pause needed to keep from stumbling over itself at the beginning
                    If linkListPosition + 1 >= linkList.Count - 1 Then
                        stopFlag = True
                    End If
                End If
            End While

            waitUntilAllThreadsAreDone()
        End Sub

        Private Sub giveToNextAvailableThread(ByVal url As String)
            While True
                If Not phase1Worker.IsBusy Then
                    phase1Stream.url = url
                    phase1Stream.threadNumber = 1
                    phase1Stream.myRefNumber = currentRefNumber
                    phase1Worker.RunWorkerAsync()
                    Exit Sub
                Else
                    If Not phase2Worker.IsBusy Then
                        phase2Stream.url = url
                        phase2Stream.threadNumber = 2
                        phase2Stream.myRefNumber = currentRefNumber
                        phase2Worker.RunWorkerAsync()
                        Exit Sub
                    Else
                        If Not phase3Worker.IsBusy Then
                            phase3Stream.url = url
                            phase3Stream.threadNumber = 3
                            phase3Stream.myRefNumber = currentRefNumber
                            phase3Worker.RunWorkerAsync()
                            Exit Sub
                        Else
                            If Not phase4Worker.IsBusy Then
                                phase4Stream.url = url
                                phase4Stream.threadNumber = 4
                                phase4Stream.myRefNumber = currentRefNumber
                                phase4Worker.RunWorkerAsync()
                                Exit Sub
                            Else
                                If Not phase5Worker.IsBusy Then
                                    phase5Stream.url = url
                                    phase5Stream.threadNumber = 5
                                    phase5Stream.myRefNumber = currentRefNumber
                                    phase5Worker.RunWorkerAsync()
                                    Exit Sub
                                Else
                                    If Not phase6Worker.IsBusy Then
                                        phase6Stream.url = url
                                        phase6Stream.threadNumber = 6
                                        phase6Stream.myRefNumber = currentRefNumber
                                        phase6Worker.RunWorkerAsync()
                                        Exit Sub
                                    Else
                                        If Not phase7Worker.IsBusy Then
                                            phase7Stream.url = url
                                            phase7Stream.threadNumber = 7
                                            phase7Stream.myRefNumber = currentRefNumber
                                            phase7Worker.RunWorkerAsync()
                                            Exit Sub
                                        Else
                                            If Not phase8Worker.IsBusy Then
                                                phase8Stream.url = url
                                                phase8Stream.threadNumber = 8
                                                phase8Stream.myRefNumber = currentRefNumber
                                                phase8Worker.RunWorkerAsync()
                                                Exit Sub
                                            Else
                                                If Not phase9Worker.IsBusy Then
                                                    phase9Stream.url = url
                                                    phase9Stream.threadNumber = 9
                                                    phase9Stream.myRefNumber = currentRefNumber
                                                    phase9Worker.RunWorkerAsync()
                                                    Exit Sub
                                                Else
                                                    If Not phase0Worker.IsBusy Then
                                                        phase0Stream.url = url
                                                        phase0Stream.threadNumber = 0
                                                        phase0Stream.myRefNumber = currentRefNumber
                                                        phase0Worker.RunWorkerAsync()
                                                        Exit Sub
                                                    Else
                                                        Thread.Sleep(70)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End While
        End Sub

        Private Sub waitUntilAllThreadsAreDone()
            While True
                If Not phase1Worker.IsBusy Then
                    If Not phase2Worker.IsBusy Then
                        If Not phase3Worker.IsBusy Then
                            If Not phase4Worker.IsBusy Then
                                If Not phase5Worker.IsBusy Then
                                    If Not phase6Worker.IsBusy Then
                                        If Not phase7Worker.IsBusy Then
                                            If Not phase8Worker.IsBusy Then
                                                If Not phase9Worker.IsBusy Then
                                                    If Not phase0Worker.IsBusy Then
                                                        Exit Sub
                                                    Else
                                                        Thread.Sleep(100)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End While
        End Sub

    End Class

    Public Class Phase
        Private m_frm As Form1

        Public url As String
        Public threadNumber As Integer
        Public myRefNumber As Integer
        Private myTempInvertedIndex As New List(Of word)

        'currentResultDomain is used for each link found in the page
        Private currentResultDomain As String
        'currentURLDomain is the domain of the current link being scanned
        Private currentURLDomain As String
        Private pageData As String
        Private pageDataCleanedUp As String

        Private domain As String
        Private h1tag As String
        Private h2tag As String
        Private h3tag As String
        Private h4tag As String
        Private h5tag As String
        Private h6tag As String
        Private pageTitle As String

        Public Sub New(ByRef p_form As Form1)
            m_frm = p_form
        End Sub

        Public Sub scan()
            updateMyLabel("down: " + url)
            pageData = byteToString(downloadStream(url))
            currentURLDomain = getDomainLocal(url)
            currentURLDomain = httpCheck(currentURLDomain)

            If pageData = "" Then
                'nothing downloaded :(
                Exit Sub
            End If

            updateMyLabel("scan: " + url)
            createTempInvertedIndex(pageData)

            updateMyLabel("merge: " + url)
            If myTempInvertedIndex.Count > 0 Then
                Try
                    m_frm.mergeThis(myTempInvertedIndex)
                Catch ex As Exception
                    MsgBox("merge failed :(" + Chr(13) + url)
                End Try
            End If

            updateMyLabel("links: " + url)

            Dim pageIndex As Integer = 1
            Dim snipStart As Integer
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim markChar As Char
            Dim result As String = ""

            While pageIndex > 0
                pageIndex = InStr(pageIndex + 1, pageData, "href=")
                If pageIndex = 0 Then
                    Exit While
                End If

                'start immediately after href=
                snipStart = pageIndex + 5
                'get the next character
                markChar = CChar(Mid(pageData, snipStart, 1))
                'find the end of the link based on what the character was
                If markChar = Chr(39) Then
                    snipEnd = InStr(snipStart + 3, pageData, Chr(39))
                End If
                If markChar = Chr(34) Then
                    snipEnd = InStr(snipStart + 3, pageData, Chr(34))
                Else
                    snipEnd = InStr(snipStart + 3, pageData, markChar)
                End If
                snipStart += 1
                snipLen = snipEnd - snipStart
                If snipLen <= 0 Then
                    snipLen = 1
                End If

                'extract the link
                result = Mid(pageData, snipStart, snipLen)

                If result.Contains("%") Then
                    result = hexCheck(result)
                End If

                If Not isGarbage(result) Then
                    'perform additional checks AFTER making sure it's not garbage
                    If isRelative(result) Then
                        If Mid(result, 1, 1) = "/" Then
                            result = currentURLDomain + result
                        Else
                            result = currentURLDomain + "/" + result
                        End If
                    End If
                    currentResultDomain = getDomainLocal(result)
                    result = httpCheck(result)
                    result = normalize(result, currentResultDomain)

                    If currentResultDomain.Contains(masterDomainNoWWW) Then
                        If Not linkList.Contains(result) Then
                            'this check should eliminate (?) www.-related duplicate links
                            If Not linkList.Contains(result.Replace("www.", "")) Then
                                Dim linkPlusWWW As String = result.Replace("http://", "")
                                linkPlusWWW = "http://www." + linkPlusWWW
                                If Not linkList.Contains(linkPlusWWW) Then
                                    linkList.Add(result)
                                    m_frm.streamUpdateHostPosition(linkListPosition, linkList.Count)
                                    m_frm.streamUpdateSiteProgress(linkListPosition, linkList.Count)
                                    'check for associated image, removed
                                End If
                            End If
                        End If
                    Else
                        'if master domain is different than the one we're working on
                        If Not domainList.Contains(httpCheck(currentResultDomain)) Then
                            If Not currentResultDomain = "" Then
                                domainList.Add(httpCheck(currentResultDomain))
                                m_frm.streamUpdateDomainListPosition(domainListPosition, domainList.Count)
                            End If
                        End If
                    End If
                End If

                pageIndex = snipEnd
            End While

            updateMyLabel("done: " + url)
        End Sub

        Public Sub createTempInvertedIndex(ByVal pageData As String)
            domain = getDomainLocal(url)
            'REALLY? we were downloading everything twice??
            'pageData = byteToString(downloadStream(url))
            pageDataCleanedUp = removeScripts(pageData)
            pageDataCleanedUp = removeTags(pageDataCleanedUp)
            pageDataCleanedUp = removeExcessPunctuation(pageDataCleanedUp)
            pageDataCleanedUp = removeConsecutiveSpaces(pageDataCleanedUp)

            h1tag = getH1tag(pageData)
            h2tag = getH2tag(pageData)
            h3tag = getH3tag(pageData)
            h4tag = getH4tag(pageData)
            h5tag = getH5tag(pageData)
            h6tag = getH6tag(pageData)
            pageTitle = getTitleTag(pageData)

            'determine weighted scores for each word
            'include number of times used, is it in a bigger font, is it in the title, etc

            '1. extract all words from document (remove tags, remove punctuation, words separated by spaces(?))
            '2. create a forward index
            '3. the page will be referred to numerically based on the order it was saved in
            '4. a separate file will contain the original page url of the forward index
            '5. create a separate, temporary inverted index of the page (sort the forward index by word)
            '6. merge the index from step 5 into the full inverted index (the full inverted index should be a jagged array)
            '7. delete the forward index? I don't see any reason to keep that data. all we need is the reference to the original file.

            'modified index format: (1, 3, 16) would mean document 1, word 3, word importance 16 (in the inverted index)

            Dim forwardIndex(countWords(pageDataCleanedUp)) As word
            Dim listOfWords() As String = Split(pageDataCleanedUp, " ")

            Dim listWord As String
            Dim wordWeight As Double
            Dim wordCounter As Integer = -1

            For Each listWord In listOfWords
                wordCounter += 1

                If Not containsNoLetters(listOfWords(wordCounter)) Then
                    listOfWords(wordCounter) = LCase(listOfWords(wordCounter))

                    wordWeight = 1
                    If h1tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.9
                    If h2tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.7
                    If h3tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.5
                    If h4tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.3
                    If h5tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.1
                    If h6tag.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 1.0
                    If pageTitle.Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 2.0
                    If LCase(url).Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 2.0
                    If LCase(domain).Contains(listOfWords(wordCounter)) Then wordWeight = wordWeight * 10.0
                    Dim countOnce As Integer = countOccurrences(pageDataCleanedUp, listOfWords(wordCounter))
                    For i = 0 To countOnce
                        wordWeight = wordWeight * 1.1
                    Next

                    forwardIndex(wordCounter).text = listOfWords(wordCounter)
                    forwardIndex(wordCounter).refNumber = myRefNumber
                    forwardIndex(wordCounter).index = wordCounter
                    forwardIndex(wordCounter).weight = FormatNumber(wordWeight, 2)
                End If

                If wordCounter + 1 = listOfWords.Count Then
                    Exit For
                End If
            Next

            'create a separate, temporary inverted index of the page (sort the forward index by word)

            Dim tempInvertedIndex As New List(Of word)
            Dim tempWordList As New List(Of String)
            Dim tempWord As word
            wordCounter = -1

            For Each tempWord In forwardIndex
                wordCounter += 1

                'If Not tempWordList.Contains(forwardIndex(wordCounter).text) Then
                tempWordList.Add(forwardIndex(wordCounter).text)
                tempInvertedIndex.Add(forwardIndex(wordCounter))
                'End If

                If wordCounter + 1 = listOfWords.Count Then
                    Exit For
                End If
            Next

            myTempInvertedIndex = tempInvertedIndex
        End Sub

        Private Sub updateMyLabel(ByVal text As String)
            Select Case threadNumber
                Case 1
                    m_frm.streamUpdate1(text)
                Case 2
                    m_frm.streamUpdate2(text)
                Case 3
                    m_frm.streamUpdate3(text)
                Case 4
                    m_frm.streamUpdate4(text)
                Case 5
                    m_frm.streamUpdate5(text)
                Case 6
                    m_frm.streamUpdate6(text)
                Case 7
                    m_frm.streamUpdate7(text)
                Case 8
                    m_frm.streamUpdate8(text)
                Case 9
                    m_frm.streamUpdate9(text)
                Case 0
                    m_frm.streamUpdate0(text)
            End Select
        End Sub


        Private Function containsNoLetters(ByVal input As String) As Boolean
            For i = 0 To input.Length - 1
                If Char.IsLetter(input, i) Then
                    Return False
                    Exit Function
                End If
            Next

            Return True
        End Function

        Private Function countOccurrences(ByVal sourceText As String, ByVal textWord As String) As Integer
            Dim numOccurrences As Integer = 0
            Dim snipStart As Integer = 1

            sourceText = LCase(sourceText)
            textWord = " " + textWord + " "

            snipStart = InStr(sourceText, textWord)
            While snipStart > 0
                numOccurrences += 1
                snipStart += 1
                snipStart = InStr(snipStart, sourceText, textWord)
            End While

            Return numOccurrences
        End Function

        Private Function countWords(ByVal input As String) As Integer
            Return Split(input, " ").Length
        End Function

        Private Function removeScripts(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer

            snipStart = InStr(input, "<script")
            While snipStart > 0
                snipEnd = InStr(snipStart + 1, input, "</script>") + 8
                snipLen = snipEnd - snipStart + 1

                If snipLen > 0 Then
                    input = input.Remove(snipStart - 1, snipLen)

                    snipStart = 1
                    snipStart = InStr(snipStart, input, "<script")
                Else
                    Exit While
                End If
            End While

            snipStart = InStr(input, "{")
            While snipStart > 0
                snipEnd = InStr(snipStart + 1, input, "}")
                snipLen = snipEnd - snipStart + 1

                If snipLen > 0 Then
                    input = input.Remove(snipStart - 1, snipLen)

                    snipStart = 1
                    snipStart = InStr(snipStart, input, "{")
                Else
                    Exit While
                End If
            End While

            Return input
        End Function

        Private Function removeTags(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer

            snipStart = InStr(input, "<")
            While snipStart > 0
                snipEnd = InStr(snipStart + 1, input, ">")
                snipLen = snipEnd - snipStart + 1

                If snipLen > 0 Then
                    input = input.Remove(snipStart - 1, snipLen)

                    snipStart = 1
                Else
                    Exit While
                End If

                snipStart = InStr(snipStart, input, "<")
            End While

            Return input
        End Function

        Private Function removeExcessPunctuation(ByVal input As String) As String
            input = Replace(input, "    ", " ")
            input = Replace(input, "	", " ")
            input = Replace(input, "&nbsp;", " ")
            input = Replace(input, "&amp", "&")
            input = Replace(input, " / ", " ")
            input = Replace(input, " | ", " ")
            input = Replace(input, " ^ ", " ") 'not working
            input = Replace(input, " - ", " ")
            input = Replace(input, ".", " ")
            input = Replace(input, "*", " ") 'asterisk and comma reserved for index
            input = Replace(input, ",", "")
            input = Replace(input, "!", "") 'use ! to separate the new multi-index values?
            input = Replace(input, "?", " ")
            input = Replace(input, "#", " ")
            input = Replace(input, ";", "")
            input = Replace(input, ":", "")
            input = Replace(input, "/", " ")
            input = Replace(input, "(", " ")
            input = Replace(input, ")", " ")
            input = Replace(input, "' ", " ")
            input = Replace(input, " '", " ")
            input = Replace(input, "<", " ")
            input = Replace(input, ">", " ")
            input = Replace(input, "[", " ")
            input = Replace(input, "]", " ")
            input = Replace(input, Chr(10), " ") 'line feed
            input = Replace(input, Chr(13), " ") 'line return
            input = Replace(input, Chr(34), "") 'quotation mark

            If domain.Contains("wikipedia.org") Then
                Dim snipStart As Integer = 1
                Dim snipEnd As Integer
                Dim snipLen As Integer
                Dim cite As String

                snipStart = InStr(input, "[")
                While snipStart > 0
                    snipEnd = InStr(snipStart + 1, input, "]")
                    snipLen = snipEnd - snipStart + 1

                    If snipLen > 0 Then
                        cite = Mid(input, snipStart, snipLen)
                        input = input.Remove(snipStart - 1, snipLen)

                        snipStart = 1
                    Else
                        Exit While
                    End If

                    snipStart = InStr(snipStart, input, "[")
                End While

                input = Replace(input, "&#160", " ")
                input = Replace(input, "%20", " ")
            End If

            Return input
        End Function

        Private Function removeConsecutiveSpaces(ByVal input As String) As String
            While InStr(input, "  ") > 0
                input = input.Replace("  ", " ")
            End While

            Return input
        End Function


        Private Function getH1tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h1")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h1>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getH2tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h2")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h2>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getH3tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h3")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h3>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getH4tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h4")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h4>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getH5tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h5")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h5>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getH6tag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipHeading As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<h6")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</h6>") + 5
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipHeading = Mid(input, snipStart, snipLen)
                    snipHeading = removeTags(snipHeading)
                End If
            End If

            Return snipHeading
        End Function

        Private Function getTitleTag(ByVal input As String) As String
            Dim snipStart As Integer = 1
            Dim snipEnd As Integer
            Dim snipLen As Integer
            Dim snipTitle As String = ""

            input = LCase(input)

            snipStart = InStr(snipStart, input, "<title>")
            If snipStart > 0 Then
                snipEnd = InStr(snipStart + 1, input, "</title>") + 8
                snipLen = snipEnd - snipStart + 1

                If snipLen >= 1 Then
                    snipTitle = Mid(input, snipStart, snipLen)
                    snipTitle = removeTags(snipTitle)
                End If
            End If

            Return snipTitle
        End Function

    End Class

    Public Class searcher
        Private m_frm As Form1
        Public singleWord As String
        Private singleWordResult As New wordMultiInfo

        Private refListTextOnly As New List(Of String)
        Private refListNumberOnly As New List(Of Integer)

        Public Sub New(ByRef p_form As Form1)
            m_frm = p_form
        End Sub

        Public Sub findSingle()
            'reset variables for new search
            refListNumberOnly.Clear()
            refListTextOnly.Clear()

            'refList and inverted index need to be loaded already
            splitRefList()

            'retrieve the matching word - BINARY!
            Dim resultIndex As Integer
            Dim lowBound As Integer = 0
            Dim upBound As Integer = loadedIndex.Count - 1

            While True
                resultIndex = (upBound - lowBound) / 2

                If resultIndex = 0 Then
                    singleWordResult.text = ""
                    Exit While
                End If

                resultIndex += lowBound

                Select Case loadedIndex(resultIndex).text
                    Case Is = singleWord
                        singleWordResult = loadedIndex(resultIndex)
                        Exit While
                    Case Is < singleWord
                        lowBound = resultIndex
                    Case Is > singleWord
                        upBound = resultIndex
                End Select
            End While

            If Not singleWordResult.text = "" Then
                'sort result by word weight
                singleWordResult.infoList.Sort()

                'print out html code, replacing refNumber with url from refList
                Using sw As New StreamWriter(path + "searchResults.html")
                    sw.Write("<html><h1>Results for ")
                    sw.Write(singleWord)
                    sw.WriteLine("</h1>")
                    sw.Write("time to process query: ")
                    endTime = Now
                    elapsedTime = endTime.Subtract(startTime)
                    sw.Write(elapsedTime.TotalSeconds.ToString("0.000")) 'come back and run a timer, put result here
                    sw.Write(" seconds")
                    sw.WriteLine("<br>")
                    sw.Write("number of results returned (including hidden, duplicates): ")
                    sw.Write(CStr(singleWordResult.infoList.Count))
                    sw.WriteLine("<br><br>")

                    Dim usedRefNumbers As New List(Of Integer)

                    For j = 0 To singleWordResult.infoList.Count - 1
                        If Not usedRefNumbers.Contains(singleWordResult.infoList(j).refNumber) Then
                            usedRefNumbers.Add(singleWordResult.infoList(j).refNumber)
                            If m_frm.CheckBoxTop100.Checked Then
                                If usedRefNumbers.Count > 100 Then
                                    Exit For
                                End If
                            End If
                            If refListTextOnly(refListNumberOnly.IndexOf(singleWordResult.infoList(j).refNumber)).Contains(m_frm.TextBoxMustContain.Text) Then
                                sw.WriteLine("")
                                sw.Write("<p><a href=")
                                sw.Write(refListTextOnly(refListNumberOnly.IndexOf(singleWordResult.infoList(j).refNumber)))
                                sw.Write(">")
                                sw.Write(refListTextOnly(refListNumberOnly.IndexOf(singleWordResult.infoList(j).refNumber)))
                                sw.WriteLine("</a><br>")
                                If m_frm.CheckBoxShowTextWithResults.Checked Then
                                    sw.Write(return10WordsBeforeAndAfter(singleWordResult.text, returnAllWordsForThisRefNumber(singleWordResult.infoList(j).refNumber)))
                                    sw.WriteLine("<br>")
                                End If
                                sw.Write("<b>word weight of ")
                                sw.Write(CStr(singleWordResult.infoList(j).weight))
                                sw.WriteLine("</b></p>")
                            End If
                        End If
                    Next

                    sw.WriteLine("</html>")
                    sw.Close()
                End Using
            Else
                MsgBox("no results for " + singleWord)
                'no results found
            End If
        End Sub

        Private Sub splitRefList()
            For i = 0 To loadedRefList.Count - 1
                Dim splitData(1) As String
                splitData = loadedRefList(i).Split(" ")

                refListNumberOnly.Add(CInt(splitData(0)))
                refListTextOnly.Add(splitData(1))
            Next
        End Sub
    End Class

    Public Structure word
        Implements IComparer
        Implements IComparable
        Dim text As String
        Dim refNumber As Integer
        Dim index As Integer
        Dim weight As Double

        Public Sub New(ByVal text As String, ByVal index As Integer, ByVal weight As Double)

        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Compare = CType(x, word).text < CType(y, word).text
        End Function

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim compData As word = CType(obj, word)

            If compData.text < Me.text Then
                Return 1
            End If
            If compData.text > Me.text Then
                Return -1
            Else
                Return 0
            End If
        End Function
    End Structure

    Public Class wordInfoOnly
        Implements IComparable
        Public refNumber As Integer
        Public index As Integer
        Public weight As Double

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim compData As wordInfoOnly = CType(obj, wordInfoOnly)

            If compData.weight < Me.weight Then
                Return -1
            End If
            If compData.weight > Me.weight Then
                Return 1
            Else
                Return 0
            End If
        End Function
    End Class

    Public Class wordMultiInfo
        Implements IComparable
        Public text As String
        Public infoList As New List(Of wordInfoOnly)

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            Dim compData As wordMultiInfo = CType(obj, wordMultiInfo)

            If compData.text < Me.text Then
                Return 1
            End If
            If compData.text > Me.text Then
                Return -1
            Else
                Return 0
            End If
        End Function
    End Class


    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        ButtonStart.Enabled = False
        ButtonResume.Enabled = False
        ComboBox1.Enabled = False

        Dim enteredDomain As String = getDomain(ComboBox1.Text)

        domainList.Add(httpCheck(enteredDomain))
        streamUpdateScanningHost(enteredDomain)

        'should this be checking for www. variations too?
        'this issue needs to be fixed by normalizing domain names before they are ever scanned
        If File.Exists(path + "main\" + enteredDomain + ".txt") Then
            loadLinkListFromFile(enteredDomain)
            'make sure site isn't completed already
            While linkListPosition = linkList.Count - 1
                loadDomainList()
                'make sure there's something in the domain list
                If domainListPosition = domainList.Count - 1 Then
                    MsgBox("nothing to scan!")
                    Exit Sub
                Else
                    domainListPosition += 1
                    writeOutDomainList()
                    streamUpdateScanningHost(domainList(domainListPosition))
                    streamUpdateDomainListPosition(domainListPosition, domainList.Count - 1)
                    linkList.Clear()
                    loadLinkListFromFile(Replace(domainList(domainListPosition), "http://", ""))
                End If
            End While
        Else
            loadDomainList()
            linkList.Add(httpCheck(enteredDomain))
        End If

        scheduleWorker.RunWorkerAsync()
    End Sub

    Private Sub ButtonResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResume.Click
        ButtonStart.Enabled = False
        ButtonResume.Enabled = False
        ComboBox1.Enabled = False

        loadDomainList()
        streamUpdateScanningHost(domainList(domainListPosition))

        'this code can be simplified, possibly. checks for variations on www. at the beginning
        'this issue needs to be fixed by normalizing domain names before they are ever scanned
        Dim loaded As Boolean = False
        If File.Exists(path + "main\" + Replace(domainList(domainListPosition), "http://", "") + ".txt") Then
            loadLinkListFromFile(Replace(domainList(domainListPosition), "http://", ""))
            loaded = True
        End If
        If Not loaded Then
            If File.Exists(path + "main\www." + Replace(domainList(domainListPosition), "http://", "") + ".txt") Then
                loadLinkListFromFile("www." + Replace(domainList(domainListPosition), "http://", ""))
                loaded = True
            End If
        End If
        If Not loaded Then
            If File.Exists(path + "main\" + Replace(Replace(domainList(domainListPosition), "http://", ""), "www.", "") + ".txt") Then
                loadLinkListFromFile(Replace(Replace(domainList(domainListPosition), "http://", ""), "www.", ""))
            End If
        End If

        While linkListPosition = linkList.Count - 1
            loadDomainList()
            'make sure there's something in the domain list
            If domainListPosition = domainList.Count - 1 Then
                MsgBox("nothing to scan!")
                Exit Sub
            Else
                domainListPosition += 1
                writeOutDomainList()
                streamUpdateScanningHost(domainList(domainListPosition))
                streamUpdateDomainListPosition(domainListPosition, domainList.Count - 1)
                linkList.Clear()
                loadLinkListFromFile(Replace(domainList(domainListPosition), "http://", ""))
            End If
        End While

        scheduleWorker.RunWorkerAsync()
    End Sub

    Private Sub ButtonShowFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowFolder.Click
        System.Diagnostics.Process.Start(path + "\main\")
    End Sub

    Private Sub ButtonDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDebug.Click
        System.Diagnostics.Process.Start(path + "info.txt")
    End Sub

    Private Sub ButtonClearDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearDebug.Click
        Using sw As StreamWriter = New StreamWriter(path + "info.txt", False)
            sw.Close()
        End Using
    End Sub

    Private Sub ButtonWriteOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteOut.Click
        'writeOutDomainList()
        'writeOutSite()
        'writeOutRefList()
        'writeOutInvertedIndexFromListOfWordMultiInfo()
        scheduleStream.writeOutNextChance = True
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        startTime = Now

        If loadedIndex.Count = 0 Then
            loadRefListAndInvertedIndexForSearchProcess()
        End If

        searchStream.singleWord = TextBox2.Text
        searchWorker.RunWorkerAsync()
    End Sub

    Private Sub ButtonRebuild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRebuild.Click
        If loadedIndex.Count = 0 Then
            loadRefListAndInvertedIndexForSearchProcess()
        End If

        MsgBox(returnAllWordsForThisRefNumber(CInt(TextBoxRebuildNumber.Text)))
    End Sub

    Private Sub ButtonReloadIndex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReloadIndex.Click
        ButtonReloadIndex.Enabled = False
        loadRefListAndInvertedIndexForSearchProcess()
        ButtonReloadIndex.Enabled = True
    End Sub

    Private Sub ButtonWriteOutSiteOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteOutSiteOnly.Click
        writeOutDomainList()
        writeOutSite()
        'writeOutRefList()
    End Sub

    Private Sub LabelDomainListPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelDomainListPosition.Click
        Using sw As StreamWriter = New StreamWriter(path + "domainList.txt", False)
            For i = 0 To domainList.Count - 1
                sw.WriteLine(domainList(i))
            Next
            sw.Close()
        End Using

        System.Diagnostics.Process.Start(path + "domainList.txt")
    End Sub

    Private Sub LabelHostPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelHostPosition.Click
        Using sw As StreamWriter = New StreamWriter(path + "siteList.txt", False)
            For i = 0 To linkList.Count - 1
                sw.WriteLine(linkList(i))
            Next
            sw.Close()
        End Using

        System.Diagnostics.Process.Start(path + "siteList.txt")
    End Sub

    Private Sub RadioButtonExternal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonExternal.CheckedChanged
        If RadioButtonExternal.Checked Then
            RadioButtonHere.Checked = False
        Else
            RadioButtonHere.Checked = True
        End If
    End Sub

    Private Sub RadioButtonHere_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonHere.CheckedChanged
        If RadioButtonHere.Checked Then
            RadioButtonExternal.Checked = False
        Else
            RadioButtonExternal.Checked = True
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim clickedText As String = Label1.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim clickedText As String = Label2.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim clickedText As String = Label3.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim clickedText As String = Label4.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Dim clickedText As String = Label5.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim clickedText As String = Label6.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Dim clickedText As String = Label7.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Dim clickedText As String = Label8.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Dim clickedText As String = Label9.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub

    Private Sub Label0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label0.Click
        Dim clickedText As String = Label0.Text
        Dim snipstart As Integer = InStr(clickedText, "http://")
        Dim thisURL As String = Mid(clickedText, snipstart, (clickedText.Length - snipstart + 1))

        openLink(thisURL)
    End Sub


    Public Shared Function getDomain(ByVal input As String) As String
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse

        request = WebRequest.Create(httpCheck(input))

        Try
            response = request.GetResponse()
            input = response.ResponseUri.Host
            response.Close()
            'lastServerDir = response.ResponseUri.AbsolutePath
            'reader = response.GetResponseStream()
        Catch ex As Exception
            Return "Nothing"
            Exit Function
        End Try

        Return input
    End Function

    Public Shared Function getDomainLocal(ByVal input As String) As String
        Dim masterStart As Integer
        Dim masterEnd As Integer
        Dim masterLength As Integer
        Dim result As String

        If Not input.Replace("http://", "").Contains("/") Then
            input = input + "/"
        End If

        masterStart = 8
        masterEnd = InStr(9, input, "/")
        masterLength = masterEnd - masterStart

        If masterLength <= 0 Then
            result = ""
        Else
            result = Mid(input, masterStart, masterLength)
        End If

        Return result
    End Function

    Public Shared Function httpCheck(ByVal input As String) As String
        Dim result As String = input

        If Not InStr(input, "http://") = 1 Then
            result = "http://" + input
        Else
            result = input
        End If

        Return result
    End Function

    Public Shared Function hexCheck(ByVal result As String) As String

        result = Replace(result, "%3A", ":")
        result = Replace(result, "%2F", "/")
        result = Replace(result, "%3D", "=")
        result = Replace(result, "%E2%80%93", "–")
        result = Replace(result, "%26", "&")
        result = Replace(result, "%27", "'")
        result = Replace(result, "%24", "$")
        result = Replace(result, "%2B", "+")
        result = Replace(result, "%2C", ",")
        result = Replace(result, "%3B", ";")
        result = Replace(result, "%3F", "?")
        result = Replace(result, "%40", "@")
        result = Replace(result, "%21", "!") 'correct?

        Return result
    End Function

    Public Shared Function downloadStream(ByVal URL As String, _
       Optional ByRef UserName As String = "", _
       Optional ByRef Password As String = "") As Byte()
        Dim Req As HttpWebRequest
        Dim SourceStream As System.IO.Stream
        Dim Response As HttpWebResponse

        Try
            'Ignore bad https certificates - expired, untrusted, bad name, etc.  
            'ServicePointManager.CertificatePolicy = New MyAcceptCertificatePolicy

            'create a web request to the URL  
            Req = HttpWebRequest.Create(URL)

            'Grrrrr.... HttpWebRequest does not know rfc  
            'you cannot use http://username:password@server:port/uri  
            'Set username and password if required  
            If Len(UserName) > 0 Then
                Req.Credentials = New NetworkCredential("root", "mmanasek")
            End If

            'get a response from web site  
            Response = Req.GetResponse()

            'return host name
            'lastAccessedHostName = Response.ResponseUri.Host

            'Source stream with requested document  
            SourceStream = Response.GetResponseStream()

            'SourceStream has no ReadAll, so we must read data block-by-block  
            'Temporary Buffer and block size  
            Dim Buffer(4096) As Byte, BlockSize As Integer

            'Memory stream to store data  
            Dim TempStream As New MemoryStream
            Dim progressTotal As Integer = 0
            Dim progressLen As Integer = Response.ContentLength
            Do
                BlockSize = SourceStream.Read(Buffer, 0, 4096)
                If BlockSize > 0 Then TempStream.Write(Buffer, 0, BlockSize)
                progressTotal += BlockSize
                'If progressTotal <= progressLen Then Form1.streamUpdateFileProgress(progressTotal, progressLen)
            Loop While BlockSize > 0

            'return the document binary data  
            Return (TempStream.ToArray())
        Catch ex As Exception
            'MsgBox(ex.Message + Chr(13) + URL)
            'Using sw As StreamWriter = New StreamWriter(path + "info.txt", True)
            'sw.WriteLine("")
            'sw.WriteLine(ex.Message)
            'sw.WriteLine(URL)
            'sw.WriteLine("")
            'sw.Close()
            'End Using
        Finally
            Try
                'grrr... Using is great, but the command is not in VB.Net  
                SourceStream.Close()
                Response.Close()
            Catch ex As Exception
                'double failure?
            End Try
        End Try
    End Function

    Public Shared Function byteToString(ByVal input() As Byte) As String
        If Not input Is Nothing Then
            Return System.Text.Encoding.ASCII.GetString(input)
        Else
            Return ""
        End If
    End Function

    Public Shared Function isRelative(ByVal input As String) As Boolean
        If Mid(input, 1, 1) = "/" Then
            Return True
            Exit Function
        End If

        'check for numeric web address. can this be simplified?
        Dim numStart As Integer
        Dim numEnd As Integer
        Dim numLen As Integer
        Dim numTempStr As String
        If input.Contains("http://") Then
            numStart = 8
        Else
            numStart = 1
        End If
        numEnd = InStr(numStart, input, "/")
        If numEnd = 0 Then
            numEnd = Len(input)
        End If
        numLen = numEnd - numStart
        numTempStr = Mid(input, numStart, numLen)
        numTempStr = Replace(numTempStr, ".", "")
        numTempStr = Replace(numTempStr, ":", "")
        If IsNumeric(numTempStr) Then
            Return False
            Exit Function
        End If

        'should catch embedded links?
        'this seems hacky.. relative link isn't guaranteed by an embedded link. disabled.
        If InStr(input, "=http://") > 0 Then
            'Return True
            'Exit Function
        End If

        Dim checkList As New List(Of String)
        checkList.Add(".com")
        checkList.Add(".net")
        checkList.Add(".org")
        checkList.Add(".biz")
        checkList.Add(".gov")
        checkList.Add(".edu")
        checkList.Add(".mil")
        checkList.Add(".info")
        checkList.Add(".co.jp")
        checkList.Add(".co.kr")
        checkList.Add(".co.nz")
        checkList.Add(".ae")
        checkList.Add(".be")
        checkList.Add(".ca")
        checkList.Add(".ch")
        checkList.Add(".cl")
        checkList.Add(".cn")
        checkList.Add(".de")
        checkList.Add(".es")
        checkList.Add(".fi")
        checkList.Add(".fm")
        checkList.Add(".fr")
        checkList.Add(".gg")
        checkList.Add(".it")
        checkList.Add(".jp")
        checkList.Add(".me")
        checkList.Add(".nl")
        checkList.Add(".pl")
        checkList.Add(".pt")
        checkList.Add(".ro")
        checkList.Add(".ru")
        checkList.Add(".se")
        checkList.Add(".tv")
        checkList.Add(".tw")
        checkList.Add(".uk")
        checkList.Add(".us")
        checkList.Add(".co.uk")
        checkList.Add(".ac.uk")
        Dim checksOut As Boolean = False

        For i = 0 To checkList.Count - 1
            If input.Contains(checkList(i)) Then
                checksOut = True
            End If
        Next

        If checksOut = False Then
            Return True
            Exit Function
        End If

        Return False
    End Function

    Public Shared Function isGarbage(ByVal input As String) As Boolean
        'these are things we don't want to try to download

        'obviously, it's garbage if it doesn't contain a single .
        If Not input.Contains(".") Then
            Return True
            Exit Function
        End If

        'should not equal these values
        'are these now invalid with the "." checker?
        Dim checkList As New List(Of String)
        checkList.Add("")
        checkList.Add(" ")
        checkList.Add("    ")
        checkList.Add("http:")
        checkList.Add("http")
        checkList.Add("http://")
        checkList.Add(" http:")
        checkList.Add("ttp:")
        checkList.Add("www")

        For i = 0 To checkList.Count - 1
            If input = checkList.Item(i) Then
                Return True
                Exit Function
            End If
        Next

        'should not contain these values
        Dim checkList2 As New List(Of String)
        checkList2.Add("	")
        checkList2.Add(" ")
        checkList2.Add(";")
        checkList2.Add("<")
        checkList2.Add(">")
        checkList2.Add("{")
        checkList2.Add("}")
        checkList2.Add("-equiv")
        checkList2.Add("https")

        'xhamster-specific
        If masterDomain.Contains("xhamster.com") Then
            checkList2.Add("/photos/")
            checkList2.Add("/user/")
            checkList2.Add("login.php?")
            checkList2.Add("signup.php?")
        End If

        checkList2.Add(".ico")
        checkList2.Add(".css")
        checkList2.Add(".pdf")

        checkList2.Add(".jpg")
        checkList2.Add(".JPG")
        checkList2.Add(".jpeg")
        checkList2.Add(".gif")
        checkList2.Add(".GIF")
        checkList2.Add(".png")
        checkList2.Add(".PNG")

        checkList2.Add(".swf")
        checkList2.Add(".flv")

        checkList2.Add(".mp3")
        checkList2.Add(".MP3")
        checkList2.Add(".wav")
        checkList2.Add(".ogg")

        checkList2.Add(".zip")

        checkList2.Add(".wmv")
        checkList2.Add(".mov")
        checkList2.Add(".avi")
        checkList2.Add(".mpg")
        checkList2.Add(".asf")


        For i = 0 To checkList2.Count - 1
            If InStr(input, checkList2.Item(i)) > 0 Then
                Return True
                Exit Function
            End If
        Next

        Return False
    End Function

    Public Shared Function normalize(ByVal url As String, ByVal urlDomain As String) As String
        'this function needs to do many things, see http://en.wikipedia.org/wiki/URL_normalization

        'convert host to lower case
        url = Replace(url, urlDomain, LCase(urlDomain))

        'remove the fragment
        If url.Contains("#") Then
            Dim snipEnd As Integer = InStr(url, "#")
            Dim snipStart As Integer = 1
            Dim snipLen As Integer = snipEnd - snipStart

            url = Mid(url, snipStart, snipLen)
        End If

        'remove empty querystring
        If InStrRev(url, "?") = Len(url) Then
            url = Mid(url, 1, Len(url) - 1)
        End If

        Return url
    End Function

    Public Shared Sub writeOutSite()
        Using sw As StreamWriter = New StreamWriter(path + "main\" + Replace(domainList(domainListPosition), "http://", "") + ".txt", False)
            sw.WriteLine(linkListPosition)
            For i = 0 To linkList.Count - 1
                sw.WriteLine(linkList(i))
            Next
        End Using
    End Sub

    Public Shared Sub writeOutDomainList()
        Using sw As StreamWriter = New StreamWriter(path + "main\~indexDomain.txt", False)
            sw.WriteLine(domainListPosition)
            For i = 0 To domainList.Count - 1
                sw.WriteLine(domainList(i))
            Next
        End Using
    End Sub

    Public Shared Sub loadLinkListFromFile(ByVal fileName As String)
        Using sr As New StreamReader(path + "main\" + fileName + ".txt")
            linkListPosition = CInt(sr.ReadLine)
            While Not sr.EndOfStream
                linkList.Add(sr.ReadLine)
            End While
        End Using
    End Sub

    Public Shared Sub loadDomainList()
        Using sr As New StreamReader(path + "main\~indexDomain.txt")
            domainListPosition = CInt(sr.ReadLine)
            While Not sr.EndOfStream
                domainList.Add(sr.ReadLine)
            End While
            sr.Close()
        End Using
    End Sub


    Public Sub mergeThis(ByVal tempInvertedIndex As List(Of word))
        While True
            If mainIndex_InUse Then
                Thread.Sleep(10)
            Else
                mainIndex_InUse = True
                Dim lastIndexModified As Integer

                For j = 0 To tempInvertedIndex.Count - 1
                    Dim addIndex As Double = findNearestNeighbor(tempInvertedIndex(j).text)
                    If addIndex Mod 1 = 0 Then
                        'update existing word
                        Dim blankWordInfo As New wordInfoOnly
                        blankWordInfo.index = tempInvertedIndex(j).index
                        blankWordInfo.refNumber = tempInvertedIndex(j).refNumber
                        blankWordInfo.weight = tempInvertedIndex(j).weight
                        mainIndex_working(addIndex).infoList.Add(blankWordInfo)
                    Else
                        'add new word
                        addIndex -= 0.5
                        If mainIndex_working.Count >= 2 Then
                            addIndex += 1
                        End If
                        Dim blankWordMultiInfo As New wordMultiInfo
                        blankWordMultiInfo.text = tempInvertedIndex(j).text
                        Dim blankwordInfo As New wordInfoOnly
                        blankwordInfo.index = tempInvertedIndex(j).index
                        blankwordInfo.refNumber = tempInvertedIndex(j).refNumber
                        blankwordInfo.weight = tempInvertedIndex(j).weight
                        blankWordMultiInfo.infoList.Add(blankwordInfo)
                        If mainIndex_working.Count = 0 Then
                            mainIndex_working.Add(blankWordMultiInfo)
                        Else
                            mainIndex_working.Insert(CInt(addIndex), blankWordMultiInfo)
                        End If
                        lastIndexModified = CInt(addIndex)
                    End If
                Next

                streamUpdateTSLastWordAdded(mainIndex_working(lastIndexModified).text)
                mainIndex_InUse = False
                Exit While
            End If
        End While

        streamUpdateEntriesInIndex(mainIndex_working.Count)

    End Sub

    Public Shared Function findNearestNeighbor(ByVal wordToFind As String) As Double
        Dim resultIndex As Integer
        Dim lowBound As Integer = 0
        Dim upBound As Integer = mainIndex_working.Count - 1

        'no item in list
        If mainIndex_working.Count = 0 Then
            Return 0.5
            Exit Function
        End If

        '1 item in list
        If mainIndex_working.Count = 1 Then
            Select Case mainIndex_working(0).text
                Case Is = wordToFind
                    Return resultIndex
                    Exit Function
                Case Is < wordToFind
                    Return 1.5
                    Exit Function
                Case Is > wordToFind
                    Return 0.5
                    Exit Function
            End Select
        End If

        While True
            resultIndex = (upBound - lowBound) / 2

            If resultIndex = 0 Then
                Return lowBound + 0.5
                Exit Function
            End If

            resultIndex += lowBound

            Select Case mainIndex_working(resultIndex).text
                Case Is = wordToFind
                    Return resultIndex
                    Exit Function
                Case Is < wordToFind
                    lowBound = resultIndex
                Case Is > wordToFind
                    upBound = resultIndex
            End Select
        End While

        Return resultIndex
    End Function

    Public Shared Function returnAllWordsForThisRefNumber(ByVal refNumber As Integer) As String
        Dim ListOfWord_FilterRefNumber As New List(Of word)

        'copy main inverted index into smaller index containing only the refnumber
        '(break up words with multiInfo into duplicates of the word with single info)
        For i = 0 To loadedIndex.Count - 1
            For j = 0 To loadedIndex(i).infoList.Count - 1
                If loadedIndex(i).infoList(j).refNumber = refNumber Then
                    Dim thisWord As New word
                    thisWord.text = loadedIndex(i).text
                    thisWord.index = loadedIndex(i).infoList(j).index
                    thisWord.refNumber = loadedIndex(i).infoList(j).refNumber
                    thisWord.weight = loadedIndex(i).infoList(j).weight

                    ListOfWord_FilterRefNumber.Add(thisWord)
                End If
            Next
        Next

        'sort this inverted index by "index number" values
        ListOfWord_FilterRefNumber.Sort(AddressOf compareWordTypeByIndexNumber)

        'return a string with ListOfWord_FilterRefNumber(i) + " ", etc
        Dim resultString As String = ""
        For k = 0 To ListOfWord_FilterRefNumber.Count - 1
            resultString += ListOfWord_FilterRefNumber(k).text
            resultString += " "
        Next

        Return resultString
    End Function

    Public Shared Function return10WordsBeforeAndAfter(ByVal targetWord As String, ByVal fullText As String) As String
        Dim resultText As String = ""
        Dim resultArray() As String
        Dim wordIndex As Integer
        Dim startWord As Integer
        Dim endWord As Integer

        resultArray = fullText.Split(" ")
        wordIndex = Array.IndexOf(resultArray, targetWord)

        startWord = wordIndex - 10
        endWord = wordIndex + 10

        If wordIndex - 10 < 0 Then
            endWord = wordIndex + 10 + Math.Abs(wordIndex - 10)
            startWord = 0
        Else
            If wordIndex + 10 > resultArray.Count - 1 Then
                startWord = wordIndex - 10 - Math.Abs(resultArray.Count - 1 - (wordIndex + 10)) 'maybe?
                endWord = resultArray.Count - 1
            End If
        End If

        For i = startWord To endWord
            resultText += resultArray(i)
            resultText += " "
        Next

        Return resultText
    End Function

    Public Shared Function compareWordTypeByIndexNumber(ByVal x As word, ByVal y As word) As Integer
        If x.index < y.index Then
            Return -1
        End If
        If x.index > y.index Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Shared Sub writeOutInvertedIndexFromListOfWordMultiInfo()
        Dim count As Integer = mainIndex_working.Count - 2 'this is kind of a hack. stopping 1 before end bc it gives unknown error.

        Using sw As New StreamWriter(path + "main\~invIndex.txt")
            sw.AutoFlush = True
            For i = 0 To count - 1
                sw.Write(mainIndex_working.Item(i).text)
                For j = 0 To mainIndex_working.Item(i).infoList.Count - 1
                    sw.Write("*")
                    sw.Write(mainIndex_working.Item(i).infoList(j).refNumber)
                    sw.Write(",")
                    sw.Write(mainIndex_working.Item(i).infoList(j).index)
                    sw.Write(",")
                    sw.Write(mainIndex_working.Item(i).infoList(j).weight)
                Next
                sw.Write("*")
                sw.WriteLine()
            Next
        End Using
    End Sub

    Public Shared Function loadInvertexIndexToListOfWordMultiInfo() As List(Of wordMultiInfo)
        Dim result As New List(Of wordMultiInfo)
        Dim workingText As String
        Dim resultCounter As Integer = 0

        Dim snipStart As Integer
        Dim snipEnd As Integer
        Dim snipLen As Integer

        Using sr As New StreamReader(path + "main\~invIndex.txt")
            While Not sr.EndOfStream
                resultCounter += 1
                workingText = sr.ReadLine
                Dim workingWord As New wordMultiInfo

                snipStart = 1
                snipEnd = InStr(workingText, "*")
                snipLen = snipEnd - snipStart

                workingWord.text = Mid(workingText, snipStart, snipLen)

                While InStr(snipStart, workingText, ",") > 0
                    Dim workingWordInfoOnly As New wordInfoOnly

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, ",")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.refNumber = CInt(Mid(workingText, snipStart, snipLen))

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, ",")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.index = CInt(Mid(workingText, snipStart, snipLen))

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, "*")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.weight = CDbl(Mid(workingText, snipStart, snipLen))

                    workingWord.infoList.Add(workingWordInfoOnly)
                End While

                result.Add(workingWord)
            End While
            sr.Close()
        End Using

        Return result
    End Function

    Public Shared Sub writeOutRefList()
        Using sw As New StreamWriter(path + "main\~refList.txt", False)
            sw.AutoFlush = True
            For i = 0 To refList.Count - 1
                sw.WriteLine(refList(i))
            Next
            sw.Close()
        End Using
    End Sub

    Public Shared Sub loadRefList()
        Using sr As New StreamReader(path + "main\~refList.txt")
            While Not sr.EndOfStream
                refList.Add(sr.ReadLine)
            End While
            sr.Close()
        End Using
    End Sub

    Public Shared Sub loadRefListAndInvertedIndexForSearchProcess()
        'don't forget to update this code if loadRefList() or loadInvertexIndexToListOfWordMultiInfo() chnage

        Using sr As New StreamReader(path + "main\~refList.txt")
            While Not sr.EndOfStream
                loadedRefList.Add(sr.ReadLine)
            End While
            sr.Close()
        End Using

        Dim result As New List(Of wordMultiInfo)
        Dim workingText As String
        Dim resultCounter As Integer = 0

        Dim snipStart As Integer
        Dim snipEnd As Integer
        Dim snipLen As Integer

        Using sr As New StreamReader(path + "main\~invIndex.txt")
            While Not sr.EndOfStream
                resultCounter += 1
                workingText = sr.ReadLine
                Dim workingWord As New wordMultiInfo

                snipStart = 1
                snipEnd = InStr(workingText, "*")
                snipLen = snipEnd - snipStart

                workingWord.text = Mid(workingText, snipStart, snipLen)

                While InStr(snipStart, workingText, ",") > 0
                    Dim workingWordInfoOnly As New wordInfoOnly

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, ",")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.refNumber = CInt(Mid(workingText, snipStart, snipLen))

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, ",")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.index = CInt(Mid(workingText, snipStart, snipLen))

                    snipStart = snipEnd + 1
                    snipEnd = InStr(snipStart, workingText, "*")
                    snipLen = snipEnd - snipStart

                    workingWordInfoOnly.weight = CDbl(Mid(workingText, snipStart, snipLen))

                    workingWord.infoList.Add(workingWordInfoOnly)
                End While

                result.Add(workingWord)
            End While
            sr.Close()
        End Using

        loadedIndex = result
    End Sub

    Public Shared Sub openLink(ByVal url As String)
        If Form1.RadioButtonExternal.Checked Then
            System.Diagnostics.Process.Start(url)
        Else
            Form1.TabControl1.SelectTab(2)
            Form1.WebBrowser1.Navigate(url)
        End If
    End Sub


    Friend Sub streamUpdateScanningHost(ByVal [name] As String)
        If Me.LabelScanningHost.InvokeRequired Then
            Dim _delegate As New scbScanningHost(AddressOf streamUpdateScanningHost)
            Me.Invoke(_delegate, New Object() {[name]})
        Else
            Me.LabelScanningHost.Text = "Scanning host: " + [name]
        End If
    End Sub

    Friend Sub streamUpdateHostPosition(ByVal [int] As Integer, ByVal [max] As Integer)
        If Me.LabelHostPosition.InvokeRequired Then
            Dim _delegate As New scbHostPosition(AddressOf streamUpdateHostPosition)
            Me.Invoke(_delegate, New Object() {[int], [max]})
        Else
            Me.LabelHostPosition.Text = "Host Position: " + CStr([int]) + " / " + CStr([max])
        End If
    End Sub

    Friend Sub streamUpdateDomainListPosition(ByVal [int] As Integer, ByVal [max] As Integer)
        If Me.LabelDomainListPosition.InvokeRequired Then
            Dim _delegate As New scbDomainListPosition(AddressOf streamUpdateDomainListPosition)
            Me.Invoke(_delegate, New Object() {[int], [max]})
        Else
            Me.LabelDomainListPosition.Text = "Domain List Position: " + CStr([int]) + " / " + CStr([max])
        End If
    End Sub

    Friend Sub streamUpdateEntriesInIndex(ByVal [int] As Integer)
        If Me.LabelEntriesInIndex.InvokeRequired Then
            Dim _delegate As New scbEntriesInIndex(AddressOf streamUpdateEntriesInIndex)
            Me.Invoke(_delegate, New Object() {[int]})
        Else
            'If CInt(Replace(LabelEntriesInIndex.Text, "Entries In Index: ", "")) < [int] Then
            Me.LabelEntriesInIndex.Text = "Entries In Index: " + CStr([int])
            'End If
        End If
    End Sub

    Friend Sub streamUpdate1(ByVal [text] As String)
        If Me.Label1.InvokeRequired Then
            Dim _delegate As New scb1(AddressOf streamUpdate1)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label1.Text = "Thread 1: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate2(ByVal [text] As String)
        If Me.Label2.InvokeRequired Then
            Dim _delegate As New scb2(AddressOf streamUpdate2)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label2.Text = "Thread 2: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate3(ByVal [text] As String)
        If Me.Label3.InvokeRequired Then
            Dim _delegate As New scb3(AddressOf streamUpdate3)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label3.Text = "Thread 3: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate4(ByVal [text] As String)
        If Me.Label4.InvokeRequired Then
            Dim _delegate As New scb4(AddressOf streamUpdate4)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label4.Text = "Thread 4: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate5(ByVal [text] As String)
        If Me.Label5.InvokeRequired Then
            Dim _delegate As New scb5(AddressOf streamUpdate5)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label5.Text = "Thread 5: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate6(ByVal [text] As String)
        If Me.Label6.InvokeRequired Then
            Dim _delegate As New scb6(AddressOf streamUpdate6)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label6.Text = "Thread 6: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate7(ByVal [text] As String)
        If Me.Label7.InvokeRequired Then
            Dim _delegate As New scb7(AddressOf streamUpdate7)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label7.Text = "Thread 7: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate8(ByVal [text] As String)
        If Me.Label8.InvokeRequired Then
            Dim _delegate As New scb8(AddressOf streamUpdate8)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label8.Text = "Thread 8: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate9(ByVal [text] As String)
        If Me.Label9.InvokeRequired Then
            Dim _delegate As New scb9(AddressOf streamUpdate9)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label9.Text = "Thread 9: " + [text]
        End If
    End Sub

    Friend Sub streamUpdate0(ByVal [text] As String)
        If Me.Label0.InvokeRequired Then
            Dim _delegate As New scb0(AddressOf streamUpdate0)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.Label0.Text = "Thread 0: " + [text]
        End If
    End Sub

    Friend Sub streamUpdateSiteProgress(ByVal [int] As Integer, ByVal [max] As Integer)
        If Me.ProgressBarSite.InvokeRequired Then
            Dim _delegate As New scbSiteBar(AddressOf streamUpdateSiteProgress)
            Me.Invoke(_delegate, New Object() {[int], [max]})
        Else
            If [int] >= 0 Then
                Me.ProgressBarSite.Maximum = [max]
                Me.ProgressBarSite.Value = [int]
                Me.LabelSitePct.Text = FormatPercent(([int] / [max]), 2)
                Me.TSSiteProgress.Text = "Site Progress: " + Me.LabelSitePct.Text
            End If
        End If
    End Sub

    Friend Sub streamUpdateTSLastWordAdded(ByVal [text] As String)
        If Me.StatusStrip1.InvokeRequired Then
            Dim _delegate As New scbTSLastWordAdded(AddressOf streamUpdateTSLastWordAdded)
            Me.Invoke(_delegate, New Object() {[text]})
        Else
            Me.TSLastWordAdded.Text = "Last Word Added: " + [text]
        End If
    End Sub

End Class
