using DataStructures.Structures;

namespace DataStructures
{
    public class MergeListsMyWay
    {
        PlayingWithLinkedList play = new PlayingWithLinkedList();
        public LinkedList MergeLinkedLists(int[] array1, int[] array2)
        {
            LinkedList linkedList1 = GetLinkedListFromArray(array1);
            LinkedList linkedList2 = GetLinkedListFromArray(array2);

            if (linkedList1 == null)
                return linkedList2;
            else if (linkedList2 == null)
                return linkedList2;

            LinkedList listToReturn = new LinkedList();

            Node headFrom1 = linkedList1.Head;
            Node headFrom2 = linkedList2.Head;
            while (headFrom1 != null && headFrom2 != null)
            {
                Node temp = null;
                if (headFrom1.data <= headFrom2.data)
                {
                    temp  = headFrom1;                    
                    headFrom1 = headFrom1.next;
                }
                else
                {
                    temp = headFrom2;
                    headFrom2 = headFrom2.next;
                }
                play.AtLastInsertIntoSingleList(listToReturn, temp.data);
            }

            if (headFrom2 != null)
            {                
                while (headFrom2 != null)
                {
                    play.AtLastInsertIntoSingleList(listToReturn, headFrom2.data);
                    headFrom2 = headFrom2.next;
                }
            }
            else
            {
                while (headFrom1 != null)
                {
                    play.AtLastInsertIntoSingleList(listToReturn, headFrom1.data);
                    headFrom1 = headFrom1.next;
                }
            }

            play.PrintList(linkedList1);
            play.PrintList(linkedList2);
            play.PrintList(listToReturn);

            return listToReturn;
        }


        private LinkedList GetLinkedListFromArray(int[] array)
        {
            if (array == null)
                return null;

            var linkedList = new LinkedList();
            for (int i = 0; i < array.Length; i++)
                play.AtLastInsertIntoSingleList(linkedList, array[i]);
            return linkedList;
        }
    }
}
