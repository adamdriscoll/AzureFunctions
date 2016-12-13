$PayLoad = [PSCustomObject]@{
    text ="One minute has passed!!! It's currently $((Get-Date))"
} | ConvertTo-Json

Invoke-RestMethod -Uri https://hooks.slack.com/services/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 -Method Post -Body $PayLoad