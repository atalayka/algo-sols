function Get-SumOfPositive($NumberArray)
{


if($NumberArray.Count -gt 0){($NumberArray | where {$PSItem -gt 0 } | Measure-Object -Sum).Sum}
else{return 0}

}

function Get-SumOfPositive($NumberArray)
{
if($NumberArray.count -gt 0){
$NumberArray.Foreach({
if($PSItem -gt 0){$x+=$PSItem}
else {continue}})}

if($NumberArray.count -eq 0 ){$x = 0}

return $x 
 }