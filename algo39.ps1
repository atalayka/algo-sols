Function Get-Factorial{
param(
[Parameter(Mandatory, Position=0)]
[int]$Number
)

$Fact=1
for($i=$Number; $i -gt 1; $i--){
$Fact*=$i
}
return $Fact
}

>> [int]$Comb1 = Read-Host 'Kombinasyonu alınacak grubun eleman sayısı '
>> [int]$Comb2 = Read-Host 'Gruptan seçilecek eleman sayısı'
>> if($Comb1 -lt $Comb2){throw{'Grubun eleman sayısı, seçilecek eleman sayısından daha düşük olamaz'}}
>>
$Fact1=1
for($i=$Comb1; $i -gt 1; $i--){
$Fact1*=$i
}


$Fact2=1
for($j=$Comb2;$j -gt 1; $j--){
$Fact2*=$j
}


$Gap = $Comb1 - $Comb2
$Fact3=1
for($k=$Gap; $k -gt 1; $k--){
$Fact3*=$k
}

<#--->Kombinasyon Hesabı<---#>
# a! / b! x (a-b)!
$Fact1 / ($Fact2 * $Fact3)
>>