import { Meta, StoryObj } from '@storybook/react';
import { HeroJustificationLetter } from '../../../components/Basic Components/Hero';
const meta = {
  title: 'Components/Hero',
  component: HeroJustificationLetter,
  parameters: {
    layout: 'centered',
  },
  tags: ['autodocs'],
  argTypes: {},
} satisfies Meta<typeof HeroJustificationLetter>;
export default meta;
type Story = StoryObj<typeof meta>;
export const JustificationLetter: Story = {
  name: 'Hero Justification Letter',
  args: {
    params: {
      styles: '',
    },
    fields: {
      Headline: {
        value: 'Justification Letter',
      },
      EventDate: {
        value: '',
      },
      Text: {
        value:
          'Donec mauris diam, finibus gravida dolor et, accumsan auctor augue. Aliquam erat volutpat. Nullam fringilla suscipit lectus.',
      },
      CallToAction: {
        value: {
          href: 'https://www.sitecore.com',
          anchor: 'Download letter',
        },
      },
      Image: {
        value: {
          src: 'assets/images/hackathonUSA-justification-letter-chatbox-artwork.svg',
        },
      },
    },
  },
};
