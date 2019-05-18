# Tests
Describe 'Validate InvokeWebsite response' {
    $response = Main

    It 'Test to validate response not null' {
        $response | Should not BeNullOrEmpty
    }
    
    It 'Test to validate quote not null' {
        $response.quote | Should not BeNullOrEmpty
    }

    It 'Test which validates author not null' {
        $response.author | Should not BeNullOrEmpty
    }

    It 'Test which validates category not null' {
        $response.category | Should not BeNullOrEmpty
    }
}