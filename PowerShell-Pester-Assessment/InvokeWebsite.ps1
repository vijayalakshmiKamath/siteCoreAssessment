#
# Main function to demonstrate REST call for given,
#   uri - https://andruxnet-random-famous-quotes.p.mashape.com/
#   Header - X-Mashape-Key : bckcFeIRo5mshMpc3C4ug7tmUplYp1jYdDYjsnBy5UQQpYB6dE
#
function Main 
{
    $uri = "https://andruxnet-random-famous-quotes.p.mashape.com/"
    $headers = @{}
    $headers.Add("X-Mashape-Key", "bckcFeIRo5mshMpc3C4ug7tmUplYp1jYdDYjsnBy5UQQpYB6dE")
    $response = Invoke-Website -Uri $uri -Headers $headers
    
    return $response
}

#
# Invokes the given website and returns the response.
#
function Invoke-Website
{
    Param($Uri, $Headers)

    $response = Invoke-RestMethod -Uri $uri -Method Get -Headers $headers

    return $response
}