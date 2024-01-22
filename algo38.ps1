

$a = 0..25; $b = 5..15;

$a.foreach({
        for ($i = 0; $i -lt $b.Count; $i++) {
            if ($PSItem -eq $b[$i]) {
               [int[]] $Collision += $PSItem
            }
        }
    })

$a.ForEach({
    if($Collision.Contains($PSItem)) {
        Write-Host "$PSItem " -ForegroundColor Green -NoNewline
    }
else {
    Write-Host "$PSItem " -ForegroundColor Red -NoNewline
}
    })
    ""