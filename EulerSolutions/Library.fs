namespace EulerSolutions

module EulerOne = 

    let isMultipleOf a b = a % b = 0
    
    let isMultipleOfThree x = isMultipleOf x 3  

    let isMultipleOfFive x = isMultipleOf x 5 

    let rec mainInt n sum: int =
        if n = 0 then sum
        else if isMultipleOfThree n || isMultipleOfFive n then mainInt (n-1) (n + sum)
        else mainInt (n-1) (sum)

    let main n = mainInt n 0 
