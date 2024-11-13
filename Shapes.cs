namespace Reviewer;

public static class Shapes
{
    public static void DrawLine(int size){
        for(int i = 1; i <= size; i++){
            Console.Write("*");
        }

        // to move to next line
        Console.Write("\n");
    }

    public static void DrawStripedLine(int size){
        for(int i = 1; i <= size; i++){
            if(i % 2 == 0){
                Console.Write("_");
            }else{
                Console.Write("*");
            }
        }

        // to move to next line
        Console.Write("\n");
    }
    
    public static void DrawSquare(int size){
        for(int i = 1; i <= size; i++){
            for(int j = 1; j <= size; j++){
                Console.Write("* ");
            }
            Console.Write("\n");
        }
    }

    public static void DrawParallelogram(int size){
        int left = size;
        int right = (size * 2) - 1;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= (size * 2) - 1; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");

            left--;
            right--;
        }
    }

    public static void DrawTriangle(int size){
        int right = size;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            right--;
        }
    }
    
    public static void DrawReverseTriangle(int size){
        int right = 1;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(x >= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            right++;
        }
    }

    public static void DrawIsocelesTriangle(int size){
        int left = (size / 2) + 1;
        int right = (size / 2) + 1;
        for(int y = 1; y <= (size + 1) / 2; y++){
            for(int x = 1; x <= size; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            right++;
            left--;
        }
    }

    public static void DrawReverseIsocelesTriangle(int size){
        int left = 1;
        int right = size;
        for(int y = 1; y <= (size + 1) / 2; y++){
            for(int x = 1; x <= size; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            right--;
            left++;
        }
    }

    public static void DrawHourglass(int size){
        int left = 1;
        int right = size;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            if(y >= (size / 2) + 1){
                right++;
                left--;
            }else{
                right--;
                left++;
            }
        }
    }

    public static void DrawDiamond(int size){
        int left = (size / 2) + 1;
        int right = (size / 2) + 1;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
            if(y >= (size / 2) + 1){
                right--;
                left++;
            }else{
                left--;
                right++;
            }
        }
    }

    public static void DrawZero(int size){
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(y == 1 || y == size || x == 1 || x == size){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");
        }
    }

    public static void DrawArrowUp(int size){
        int left = (size / 2) + 1;
        int right = (size / 2) + 1;
        for(int y = 1; y <= size; y++){
            for(int x = 1; x <= size; x++){
                if(x >= left && x <= right){
                    Console.Write("*");
                }else{
                    Console.Write("_");
                }
            }
            Console.Write("\n");

            if(y < (size / 2) + 1){
            	left--;
				right++;
            }else{
                left = (size / 3) + 1;
				right = ((size / 3) * 2) + 1;
            }
        }
    }

	public static void DrawArrowDown(int size){
		int left = (size / 3) + 1;
		int right = ((size / 3) * 2) + 1;
		for(int y = 1; y <= size; y++)
		{
			for(int x = 1; x <= size; x++)
			{
				if(x >= left && x <= right)
				{
					Console.Write("*");
				}else{
					Console.Write("_");
				}
			}
			Console.Write("\n");

			if(y == (size / 2))
			{
				left = 1;
				right = size;
			}else if(y > (size / 2)){
				left++;
				right--;
			}
		}
	}

	public static void DrawX(int size){
		int left = 1;
		int right = size;
		for(int y = 1; y <= size; y++){
			for(int x = 1; x <= size; x++){
				if(x == left || x == right){
					Console.Write("*");
				}else{
					Console.Write("_");
				}
			}
			Console.Write("\n");
			left++;
			right--;
		}
	}

	public static void DrawBowTie(int size){
		int left = 1; 
		int right = size;
		for(int y = 1; y <= size; y++){
			for(int x = 1; x <= size; x++){
				if(x <= left || x >= right){
					Console.Write("*");
				}else{
					Console.Write("_");
				}
			}
			Console.Write("\n");
			
			if(y > (size / 2)){
				left--;
				right++;
			}else{
				left++;
				right--;
			}
		}
	}
}
