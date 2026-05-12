$body = @{
    Username = "ADMIN"
    Password = "ADMIN"
} | ConvertTo-Json

try {
    $response = Invoke-WebRequest -Uri "http://localhost:5002/api/auth/login" -Method POST -ContentType "application/json" -Body $body
    Write-Output "Response:"
    Write-Output $response.Content
} catch {
    Write-Output "Error occurred:"
    Write-Output $_.Exception.Message
    if ($_.Exception.Response) {
        $reader = New-Object System.IO.StreamReader($_.Exception.Response.GetResponseStream())
        $reader.BaseStream.Position = 0
        $errorBody = $reader.ReadToEnd()
        Write-Output "Error body:"
        Write-Output $errorBody
    }
}
