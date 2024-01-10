function movie([int]$card, [int]$ticket, [double]$percent)
{  
    $Cost = $ticket * $percent
    do{
        $Rep++
        $SysA = $ticket * $Rep
        $totalcost+=$cost
        $SysB = [math]::ceiling($totalcost + $card)
        $Cost *= $percent
    }while($SysA -le $SysB) 
    $Rep
}
